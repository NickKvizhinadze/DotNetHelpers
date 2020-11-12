using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DotNetHelpers.Enums;
using DotNetHelpers.Exceptions;
using DotNetHelpers.Logger.Models;
using static DotNetHelpers.Options;

namespace DotNetHelpers.Logger
{
    public class LogService : ILogService
    {
        #region Error
        public Task LogError(string eventId, string eventName, string message)
        {
            return SaveLogAsync(eventId, eventName, LogLevel.Error, message, null);
        }

        public Task LogError(string eventId, string eventName, Exception exception)
        {
            return SaveLogAsync(eventId, eventName, LogLevel.Error, null, exception);
        }

        public Task LogError(string eventId, string eventName, string message, Exception exception)
        {
            return SaveLogAsync(eventId, eventName, LogLevel.Error, message, exception);
        }
        #endregion


        #region Warning
        public Task LogWarning(string eventId, string eventName, string message)
        {
            return SaveLogAsync(eventId, eventName, LogLevel.Warning, message, null);
        }

        public Task LogWarning(string eventId, string eventName, Exception exception)
        {
            return SaveLogAsync(eventId, eventName, LogLevel.Warning, null, exception);
        }

        public Task LogWarning(string eventId, string eventName, string message, Exception exception)
        {
            return SaveLogAsync(eventId, eventName, LogLevel.Error, message, exception);
        }
        #endregion


        #region Information

        public Task LogInformation(string eventId, string eventName, string message)
        {
            return SaveLogAsync(eventId, eventName, LogLevel.Information, message, null);
        }

        public Task LogInformation(string eventId, string eventName, Exception exception)
        {
            return SaveLogAsync(eventId, eventName, LogLevel.Information, null, exception);
        }

        public Task LogInformation(string eventId, string eventName, string message, Exception exception)
        {
            return SaveLogAsync(eventId, eventName, LogLevel.Information, message, exception);
        }
        #endregion


        #region Trace

        public Task LogTrace(string eventId, string eventName, string message)
        {
            return SaveLogAsync(eventId, eventName, LogLevel.Trace, message, null);
        }

        public Task LogTrace(string eventId, string eventName, Exception exception)
        {
            return SaveLogAsync(eventId, eventName, LogLevel.Trace, null, exception);
        }

        public Task LogTrace(string eventId, string eventName, string message, Exception exception)
        {
            return SaveLogAsync(eventId, eventName, LogLevel.Trace, message, exception);
        }
        #endregion


        #region Debug

        public Task LogDebug(string eventId, string eventName, string message)
        {
            return SaveLogAsync(eventId, eventName, LogLevel.Debug, message, null);
        }

        public Task LogDebug(string eventId, string eventName, Exception exception)
        {
            return SaveLogAsync(eventId, eventName, LogLevel.Debug, null, exception);
        }

        public Task LogDebug(string eventId, string eventName, string message, Exception exception)
        {
            return SaveLogAsync(eventId, eventName, LogLevel.Debug, message, exception);
        }
        #endregion


        #region Critical

        public Task LogCritical(string eventId, string eventName, string message)
        {
            return SaveLogAsync(eventId, eventName, LogLevel.Critical, message, null);
        }

        public Task LogCritical(string eventId, string eventName, Exception exception)
        {
            return SaveLogAsync(eventId, eventName, LogLevel.Critical, null, exception);
        }

        public Task LogCritical(string eventId, string eventName, string message, Exception exception)
        {
            return SaveLogAsync(eventId, eventName, LogLevel.Critical, message, exception);
        }
        #endregion


        #region Private
        private async Task SaveLogAsync(string eventId, string eventName, LogLevel logLevel, string message = "", Exception exception = null)
        {
            var log = new Log(eventId, eventName, logLevel.ToString(), message, exception?.ToString(), exception?.StackTrace.ToString(), DateTime.UtcNow.AddHours(4));
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    var sqlString = $"INSERT INTO {Schema}.{Table} (EventId, EventName, LogLevel, Message, Exception, StackTrace, CreateDate) " +
                        $"VALUES (@eventId, @eventName, @logLevel, @message, @exception, @stackTrace, @createDate)";
                    using (var command = new SqlCommand(sqlString, connection))
                    {
                        //command.Parameters.Add("@eventId", SqlDbType.VarChar, 50).Value = DBNull.Value;
                        AddSqlParameters(command, "@eventId", SqlDbType.VarChar, log.EventId, true, 50);
                        AddSqlParameters(command, "@eventName", SqlDbType.VarChar, log.EventName, true, 50);
                        AddSqlParameters(command, "@logLevel", SqlDbType.VarChar, log.LogLevel, false, 50);
                        AddSqlParameters(command, "@message", SqlDbType.NVarChar, log.Message, true, 500);
                        AddSqlParameters(command, "@exception", SqlDbType.NVarChar, log.Exception, true);
                        AddSqlParameters(command, "@stackTrace", SqlDbType.NVarChar, log.StackTrace, true);
                        AddSqlParameters(command, "@createDate", SqlDbType.DateTime2, log.CreateDate);
                        connection.Open();
                        await command.ExecuteNonQueryAsync();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new LoggerException($"Log = {JsonConvert.SerializeObject(log)}", ex);
            }
        }

        private void AddSqlParameters(SqlCommand command, string name, SqlDbType type, object value, bool isNullable = false, int? size = null)
        {
            if (isNullable && value == null)
                if (size is null)
                    command.Parameters.Add(name, type).Value = DBNull.Value;
                else
                    command.Parameters.Add(name, type, size.Value).Value = DBNull.Value;
            else
                if (size is null)
                command.Parameters.Add(name, type).Value = value;
            else
                command.Parameters.Add(name, type, size.Value).Value = value;


        }
        #endregion
    }
}
