using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DotNetHelpers.MvcCore.Middlewares
{
    public class CultureMiddleware
    {
        #region Fields
        private readonly RequestDelegate _next;
        private readonly string _defaultCulture;
        #endregion

        #region Constructor
        public CultureMiddleware(RequestDelegate next, string defaultCulture)
        {
            _next = next;
            _defaultCulture = defaultCulture;
        }
        #endregion

        #region Mthods
        public async Task Invoke(HttpContext context)
        {
            var cultureName = _defaultCulture;
            var queryCulture = context.Request.Headers["Accept-Language"].ToString();

            if (!string.IsNullOrWhiteSpace(queryCulture))
            {
                cultureName = queryCulture.Split(',')[0];
            }

            var culture = new CultureInfo(cultureName);
            CultureInfo.CurrentCulture = culture;
            CultureInfo.CurrentUICulture = culture;

            await _next(context);
        }
        #endregion
    }
}