using Microsoft.AspNetCore.Builder;
using DotNetHelpers.MvcCore.Middlewares;

namespace DotNetHelpers.MvcCore.Extensions
{
    public static class MiddlewareExtentions
    {
        #region Methods

        public static IApplicationBuilder UseGlobalExceptionHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandlerMiddleware>();
        }
        public static IApplicationBuilder UseCultureFromHeader(this IApplicationBuilder builder, string defaultCulture)
        {
            return builder.UseMiddleware<CultureMiddleware>(defaultCulture);
        }

        #endregion
    }
}
