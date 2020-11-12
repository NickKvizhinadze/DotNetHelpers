using System;
using System.Threading.Tasks;

namespace DotNetHelpers.Logger
{
    public interface ILogService
    {
        #region Error
        Task LogError(string eventId, string eventName, string message);
        Task LogError(string eventId, string eventName, Exception exception);
        Task LogError(string eventId, string eventName, string message, Exception exception);
        #endregion

        #region Warning
        Task LogWarning(string eventId, string eventName, string message);
        Task LogWarning(string eventId, string eventName, Exception exception);
        Task LogWarning(string eventId, string eventName, string message, Exception exception);
        #endregion

        #region Information
        Task LogInformation(string eventId, string eventName, string message);
        Task LogInformation(string eventId, string eventName, Exception exception);
        Task LogInformation(string eventId, string eventName, string message, Exception exception);
        #endregion


        #region Trace
        Task LogTrace(string eventId, string eventName, string message);
        Task LogTrace(string eventId, string eventName, Exception exception);
        Task LogTrace(string eventId, string eventName, string message, Exception exception);
        #endregion

        #region Debug
        Task LogDebug(string eventId, string eventName, string message);
        Task LogDebug(string eventId, string eventName, Exception exception);
        Task LogDebug(string eventId, string eventName, string message, Exception exception);
        #endregion


        #region Critical
        Task LogCritical(string eventId, string eventName, string message);
        Task LogCritical(string eventId, string eventName, Exception exception);
        Task LogCritical(string eventId, string eventName, string message, Exception exception);
        #endregion
    }
}
