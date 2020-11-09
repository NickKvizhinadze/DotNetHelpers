using System;
using System.Data.SqlClient;
using static DotNetHelpers.Logger.Config;

namespace DotNetHelpers.Logger
{
    public class LoggerConfiguration
    {
        #region Properties
        private string _connectionString;
        private string _schema = "dbo";
        private string _table = "Log";
        #endregion

        #region Methods
        public LoggerConfiguration SetConnectionString(string connectionString)
        {
            _connectionString = connectionString; 
            return this;
        }

        public LoggerConfiguration SetSchema(string schema)
        {
            _schema = schema;
            return this;
        }

        public LoggerConfiguration SetTable(string table)
        {
            _table = table;
            return this;
        }

        public void Build()
        {
            if (string.IsNullOrWhiteSpace(_connectionString))
                throw new ArgumentException("ConnectionString is required");

            Config.Init(_connectionString, _schema, _table);
            InitDb();
        }

        #endregion

        #region Private Methods
        private static void InitDb()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var sqlString = $@"IF NOT EXISTS (SELECT
      *
    FROM sys.schemas s
    WHERE [name] = '{Schema}')
  EXEC ('CREATE SCHEMA {Schema}')
GO
IF OBJECT_ID('{Schema}.{Table}') IS NULL
  CREATE TABLE {Schema}.{Table} (
    Id INT IDENTITY
   ,EventId VARCHAR(50) NULL
   ,EventName VARCHAR(50) NULL
   ,LogLevel VARCHAR(50) NOT NULL
   ,Message NVARCHAR(500) NULL
   ,Exception NVARCHAR(MAX) NULL
   ,StackTrace NVARCHAR(MAX) NULL
   ,CreateDate DATETIME2 NOT NULL
   ,CONSTRAINT PK_Logs PRIMARY KEY CLUSTERED (Id)
  ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO";
                using (var command = new SqlCommand(sqlString, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        #endregion
    }
}
