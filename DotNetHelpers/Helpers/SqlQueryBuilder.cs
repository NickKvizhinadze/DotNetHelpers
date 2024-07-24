using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using DotNetHelpers.Models;
using Wireshouse.Service.Helpers;

namespace DotNetHelpers.Helpers;

/// <summary>
/// Query builder for ms sql
/// </summary>
public class SqlQueryBuilder
{
    private string _tableName;
    private string _groupBy;

    /// <summary>
    /// Conditions for where clause
    /// </summary>
    private List<WhereCondition> _conditions = [];

    /// <summary>
    /// Select columns list
    /// </summary>
    private List<SelectColumn> _selectColumns = [];

    /// <summary>
    /// Sql Parameters
    /// </summary>
    private List<SqlParameter> _sqlParameters = [];

    /// <summary>
    /// Adds table or view name to query
    /// </summary>
    /// <param name="tableName">Table or view name</param>
    /// <returns>Sql query builder object</returns>
    public SqlQueryBuilder From(string tableName)
    {
        _tableName = tableName;
        return this;
    }

    /// <summary>
    /// Adds group by clause to query
    /// </summary>
    /// <param name="groupBy">Group by column name</param>
    /// <returns>Sql query builder object</returns>
    public SqlQueryBuilder GroupBy(string groupBy)
    {
        _groupBy = groupBy;
        return this;
    }

    /// <summary>
    /// Adds where clause conditions to query
    /// </summary>
    /// <param name="columnName">Column name which should be filtered</param>
    /// <param name="value">value of the column</param>
    /// <param name="operator">Operator</param>
    /// <param name="sqlParameter">sql parameter</param>
    /// <returns>Sql query builder object</returns>
    public SqlQueryBuilder Where(string columnName, string value, string @operator, SqlParameter sqlParameter)
    {
        _conditions.Add(new WhereCondition(columnName, value, @operator));
        _sqlParameters.Add(sqlParameter);
        return this;
    }

    /// <summary>
    /// Adds where clause conditions to query
    /// </summary>
    /// <param name="columnName">Column name which should be filtered</param>
    /// <param name="value">value of the column</param>
    /// <param name="operator">Operator</param>
    /// <returns>Sql query builder object</returns>
    public SqlQueryBuilder Where(string columnName, string value, string @operator)
    {
        _conditions.Add(new WhereCondition(columnName, value, @operator, false));
        return this;
    }

    /// <summary>
    /// Adds Select statement to query
    /// </summary>
    /// <param name="columnName">Column name</param>
    /// <param name="function">functions for the column</param>
    /// <param name="alias">Alias of the column</param>
    /// <returns>Sql query builder object</returns>
    public SqlQueryBuilder Select(string columnName, string function = "", string alias = "")
    {
        _selectColumns.Add(new SelectColumn(columnName, function, alias));
        return this;
    }

    /// <summary>
    /// Converts query builder to sql query
    /// </summary>
    /// <returns>Stringified sql query</returns>
    public string ToSql()
    {
        if (_selectColumns.Count == 0)
            _selectColumns.Add(new SelectColumn("*"));

        var result = $"SELECT {string.Join(", ", _selectColumns)} FROM {_tableName}";

        var conditions = string.Join(" AND ", _conditions);
        if (!string.IsNullOrEmpty(conditions))
            result += $" WHERE {conditions}";

        if (!string.IsNullOrEmpty(_groupBy))
            result += $" GROUP BY {_groupBy}";
        return result;
    }

    /// <summary>
    /// Clone query builder
    /// </summary>
    /// <returns>Returns new instance of same query builder</returns>
    public SqlQueryBuilder Clone()
    {
        return new SqlQueryBuilder
        {
            _conditions = _conditions
                .Select(c => new WhereCondition(c.ColumnName, c.Value, c.Operator, c.WithParameters)).ToList(),
            _selectColumns = _selectColumns.Select(s => new SelectColumn(s.Column, s.Function, s.Alias)).ToList(),
            _sqlParameters = _sqlParameters.Select(s => new SqlParameter(s.ParameterName, s.Value)).ToList(),
            _tableName = _tableName,
            _groupBy = _groupBy
        };
    }
}