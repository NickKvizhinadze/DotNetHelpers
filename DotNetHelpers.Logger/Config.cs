namespace DotNetHelpers.Logger
{
    internal static class Config
    {
        #region Properties
        internal static string ConnectionString { get; private set; }
        internal static string Schema { get; private set; }
        internal static string Table { get; private set; }
        #endregion

        #region Methods
        internal static void Init(string connectionString, string schema, string table)
        {
            ConnectionString = connectionString;
            Schema = schema;
            Table = table;
        }
        #endregion
    }
}
