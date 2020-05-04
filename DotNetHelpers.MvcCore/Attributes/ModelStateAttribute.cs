using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DotNetHelpers.MvcCore.Attributes
{
    /// <summary>
    /// Check ModelState is valid attribute
    /// </summary>
    public class ModelStateAttribute : ActionFilterAttribute
    {
        #region Methods
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
                context.Result = new BadRequestObjectResult(context.ModelState);
            base.OnActionExecuting(context);
        }
        #endregion
    }
}
