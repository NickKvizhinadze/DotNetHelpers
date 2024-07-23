using System.Net;
using System.Collections.Generic;
using DotNetHelpers.Enums;
using Microsoft.AspNetCore.Mvc;
using DotNetHelpers.Models;
using DotNetHelpers.MvcCore.Extensions;

namespace DotNetHelpers.MvcCore
{
    [Route("api/[controller]")]
    public abstract class ApiBaseController : ControllerBase
    {
        #region Protected Methods
        protected ActionResult<T> CustomResult<T>(Result<T> result)
        {
            return result.Succeeded 
                ? Ok(result.Data) 
                : ErrorResult(result);
        }

        protected IActionResult CustomResult(Result result)
        {
            return result.Succeeded
                ? NoContent()
                : ErrorResult(result);
        }
        
        protected ActionResult ErrorResult(Result result)
        {
            AddErrors(result.Errors);
            return result.Code switch
            {
                ResultCode.InternalError => CustomActionResult(HttpStatusCode.InternalServerError),
                ResultCode.EntityNotFound => CustomActionResult(HttpStatusCode.NotFound),
                ResultCode.Forbidden => CustomActionResult(HttpStatusCode.Forbidden),
                _ => CustomActionResult(HttpStatusCode.BadRequest)
            };
        }
        #endregion

        #region Private Methods
        private ActionResult CustomActionResult(HttpStatusCode statusCode)
        {
            switch (statusCode)
            {
                case HttpStatusCode.BadRequest:
                    return BadRequest(ModelState);
                default:
                    return StatusCode((int)statusCode);
            }
        }

        protected void AddErrors(IEnumerable<Error> errors)
        {
            foreach (var error in errors)
                ModelState.AddError(error);
        }
        #endregion
    }
}
