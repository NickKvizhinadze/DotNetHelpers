namespace DotNetHelpers.Models
{
    /// <summary>
    /// Sql query select column builder
    /// </summary>
    public class SelectColumn
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="column"></param>
        /// <param name="function"></param>
        /// <param name="alias"></param>
        public SelectColumn(string column, string function = "", string alias = "")
        {
            Column = column;
            Function = function;
            Alias = alias;
        }
        
        /// <summary>
        /// Column name
        /// </summary>
        public string Column { get; }
        
        /// <summary>
        /// Function name for column
        /// </summary>
        public string Function { get; }
        
        /// <summary>
        /// Column Alias
        /// </summary>
        public string Alias { get; }


        /// <summary>
        /// Generates column for select
        /// </summary>
        /// <returns>string version of column in select</returns>
        public override string ToString()
        {
            var result = !string.IsNullOrEmpty(Function) ? $"{Function}({Column})" : Column;

            if (!string.IsNullOrEmpty(Alias))
                result += $" AS {Alias}";

            return result;
        }
    }
}