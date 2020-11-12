using System;

namespace DotNetHelpers.Exceptions
{
    /// <summary>
    /// Logger Exception
    /// </summary>
    [Serializable]
    public class LoggerException : Exception
    {
        /// <summary>
        /// Empty Constructor
        /// </summary>
        public LoggerException()
        {
        }

        /// <summary>
        /// Constructor with messages
        /// </summary>
        public LoggerException(string message) : base(message)
        {
        }

        /// <summary>
        /// Constructor with messages and inner exception
        /// </summary>
        public LoggerException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
