using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using static DotNetHelpers.MvcCore.Extensions.AlertExtensions;
using DotNetHelpers.MvcCore.Enums;
using DotNetHelpers.MvcCore.Models;

namespace DotNetHelpers.MvcCore.InternalHelpers
{
    internal class AlertDecoratorResult : ActionResult
    {
        #region Properties
        internal ActionResult InnerResult { get; set; }
        internal AlertStatus Status { get; set; }
        internal string Message { get; set; }
        #endregion

        #region Constructors
        internal AlertDecoratorResult(ActionResult innerResult, AlertStatus status, string message)
        {
            InnerResult = innerResult;
            Status = status;
            Message = message;
        }
        #endregion

        #region Methods
        public override void ExecuteResult(ActionContext context)
        {
            ITempDataDictionaryFactory factory = context.HttpContext.RequestServices.GetService(typeof(ITempDataDictionaryFactory)) as TempDataDictionaryFactory;
            if (factory != null)
            {
                var tempData = factory.GetTempData(context.HttpContext);
                var alerts = tempData.GetAlerts();
                alerts.Add(new Alert(Status, Message));
                if (tempData[AlertsKey] != null)
                    tempData[AlertsKey] = JsonConvert.SerializeObject(alerts);
                else
                    tempData.Add(AlertsKey, JsonConvert.SerializeObject(alerts));
            }

            InnerResult.ExecuteResult(context);
        }

        #endregion
    }
}
