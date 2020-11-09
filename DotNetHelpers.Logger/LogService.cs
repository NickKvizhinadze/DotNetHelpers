using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DotNetHelpers.Logger.Models;
using DotNetHelpers.Logger.Enums;
using DotNetHelpers.Logger.Exceptions;

namespace DotNetHelpers.Logger
{
    internal class LogService : ILogService
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
            var log = new Log(eventId, eventName, message, logLevel.ToString(), exception?.ToString(), exception?.StackTrace.ToString(), DateTime.UtcNow.AddHours(4));
            try
            {
                using (var connection = new SqlConnection(Config.ConnectionString))
                {
                    var sqlString = "INSERT INTO Logs (EventId, EventName, LogLevel, Message, Exception, StackTrace, CreateDate) VALUES (@eventId, @eventName, @logLevel, @message, @exception, @stackTrace; @createDate";
                    using (var command = new SqlCommand(sqlString, connection))
                    {
                        command.Parameters.Add("@eventId", SqlDbType.VarChar, 50).Value = log.EventId;
                        command.Parameters.Add("@eventName", SqlDbType.VarChar, 50).Value = log.EventName;
                        command.Parameters.Add("@logLevel", SqlDbType.VarChar, 50).Value = log.LogLevel;
                        command.Parameters.Add("@message", SqlDbType.NVarChar, 500).Value = log.Message;
                        command.Parameters.Add("@exception", SqlDbType.NVarChar).Value = log.Exception;
                        command.Parameters.Add("@stackTrace", SqlDbType.NVarChar).Value = log.StackTrace;
                        command.Parameters.Add("@createDate", SqlDbType.DateTime2).Value = log.CreateDate;
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
        #endregion
    }
}
