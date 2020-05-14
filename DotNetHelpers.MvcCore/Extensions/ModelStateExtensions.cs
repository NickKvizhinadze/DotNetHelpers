using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace DotNetHelpers.MvcCore.Extensions
{
    public static class ModelStateExtensions
    {
        #region Methods
        public static void AddErrors(this ModelStateDictionary modelState, IEnumerable<KeyValuePair<string, string>> errors)
        {
            foreach (var error in errors)
                AddError(modelState, error);
        }

        public static void AddError(this ModelStateDictionary modelState, KeyValuePair<string, string> error)
        {
            modelState.AddModelError(error.Key, error.Value);
        }

        public static string GetErrorsAsString(this ModelStateDictionary modelState)
        {
            return string.Join("; ", modelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));
        }
        #endregion
    }
}
