using System.Net;
using System.Collections.Generic;
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
            if (!result.Succeeded)
                return Error(result);

            return Ok(result.Data);
        }

        protected IActionResult CustomResult(Result result)
        {
            if (!result.Succeeded)
                return Error(result);

            return NoContent();
        }

        //TODO: rename to ErrorResult
        protected ActionResult Error(Result result)
        {
            AddErrors(result.Errors);
            switch (result.ErrorStatus)
            {
                case DotNetHelpers.Enums.ErrorStatus.Server:
                    return CustomActionResult(HttpStatusCode.InternalServerError);
                case DotNetHelpers.Enums.ErrorStatus.UnAuthorized:
                    return CustomActionResult(HttpStatusCode.Unauthorized);
                case DotNetHelpers.Enums.ErrorStatus.AccessDenied:
                    return CustomActionResult(HttpStatusCode.Forbidden);
                default:
                    return CustomActionResult(HttpStatusCode.BadRequest);
            }
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

        protected void AddErrors(IEnumerable<KeyValuePair<string, string>> errors)
        {
            foreach (var error in errors)
                ModelState.AddError(error);
        }
        #endregion
    }
}
