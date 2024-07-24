namespace Wireshouse.Service.Helpers
{
    public class WhereCondition
    {
        public WhereCondition(string columnName, string value, string @operator, bool withParameters = true)
        {
            ColumnName = columnName;
            Value = value;
            Operator = @operator;
            WithParameters = withParameters;
        }

        public string ColumnName { get; private set; }
        public string Value { get; private set; }
        public string Operator { get; private set; }
        public bool WithParameters { get; private set; }

        public override string ToString()
        {
            return WithParameters ? $"{ColumnName} {Operator} @{Value}" : $"{ColumnName} {Operator} {Value}";
        }
    }
}