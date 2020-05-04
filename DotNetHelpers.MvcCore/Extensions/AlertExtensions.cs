using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;
using DotNetHelpers.MvcCore.Enums;
using DotNetHelpers.MvcCore.Models;
using DotNetHelpers.MvcCore.InternalHelpers;

namespace DotNetHelpers.MvcCore.Extensions
{
    public static class AlertExtensions
    {
        #region Constants
        public const string AlertsKey = "_Alerts";
        #endregion

        #region Methods
        public static List<Alert> GetAlerts(this ITempDataDictionary tempData)
        {
            if (!tempData.ContainsKey(AlertsKey))
                return new List<Alert>();

            return JsonConvert.DeserializeObject<List<Alert>>(tempData[AlertsKey].ToString());
        }

        public static ActionResult WithSuccess(this ActionResult result, string message)
            => new AlertDecoratorResult(result, AlertStatus.Success, message);

        public static ActionResult WithInfo(this ActionResult result, string message)
            => new AlertDecoratorResult(result, AlertStatus.Info, message);

        public static ActionResult WithWarning(this ActionResult result, string message)
            => new AlertDecoratorResult(result, AlertStatus.Warning, message);

        public static ActionResult WithError(this ActionResult result, string message)
            => new AlertDecoratorResult(result, AlertStatus.Error, message);
        #endregion
    }
}