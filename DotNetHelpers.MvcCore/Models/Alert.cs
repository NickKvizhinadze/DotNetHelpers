using DotNetHelpers.MvcCore.Enums;

namespace DotNetHelpers.MvcCore.Models
{
    public class Alert
    {
        #region Constructors
        public Alert(AlertStatus status, string message)
        {
            Status = status;
            Message = message;
        }
        #endregion

        #region Properties
        public AlertStatus Status { get; private set; }
        public string Message { get; private set; }
        #endregion
    }
}
