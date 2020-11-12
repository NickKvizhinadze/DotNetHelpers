using System;

namespace DotNetHelpers.Logger.Models
{
    internal class Log
    {
        #region Constructors
        public Log(string eventId, string eventName, string logLevel, string message, string exception, string stackTrace, DateTime createDate)
        {
            EventId = eventId;
            EventName = eventName;
            LogLevel = logLevel;
            Message = message;
            Exception = exception;
            StackTrace = stackTrace;
            CreateDate = createDate;
        }
        #endregion

        #region Properties
        public int Id { get; private set; }
        public string EventId { get; private set; }
        public string EventName { get; private set; }
        public string LogLevel { get; private set; }
        public string Message { get; private set; }
        public string Exception { get; private set; }
        public string StackTrace { get; private set; }
        public DateTime CreateDate { get; private set; }
        #endregion
    }
}
