using DotNetHelpers.Enums;

namespace DotNetHelpers.Models
{
    public partial class Result
    {
        #region Static methods
        /// <summary>
        /// Returns result class instance with success
        /// </summary>
        /// <returns></returns>
        public static Result Success() => new Result();

        /// <summary>
        /// Returns result class instance with error
        /// </summary>
        /// <param name="errorMessage">Error message</param>
        /// <returns></returns>
        public static Result Error(string errorMessage)
        {
            var result = new Result();
            result.AddError(errorMessage);
            return result;
        }
        /// <summary>
        /// Returns result class instance with error
        /// </summary>
        /// <param name="key">Error key</param>
        /// <param name="errorMessage">Error message</param>
        /// <returns></returns>
        public static Result Error(string key, string errorMessage)
        {
            var result = new Result();
            result.AddError(key, errorMessage);
            return result;
        }

        /// <summary>
        /// Returns result class instance with error when exception is occurred
        /// </summary>
        /// <param name="errorMessage">Error message</param>
        /// <returns></returns>
        public static Result Throw(string errorMessage)
        {
            var result = new Result();
            result.AddError(errorMessage, ErrorStatus.Server);
            return result;
        }

        /// <summary>
        /// Returns result class instance with error when exception is occurred
        /// </summary>
        /// <returns></returns>
        public static Result Unauthorized()
        {
            var result = new Result();
            result.AddError("Unauthorized", ErrorStatus.UnAuthorized);
            return result;
        }

        /// <summary>
        /// Returns result class instance with success
        /// </summary>
        /// <param name="data">Data</param>
        /// <typeparam name="T">Type of data property</typeparam>
        /// <returns></returns>
        public static Result<T> Success<T>(T data) => new Result<T>(data);

        /// <summary>
        /// Returns result class instance with error
        /// </summary>
        /// <typeparam name="T">Type of data property</typeparam>
        /// <param name="errorMessage">Error message</param>
        /// <returns></returns>
        public static Result<T> Error<T>(string errorMessage)
        {
            var result = new Result<T>();
            result.AddError(errorMessage);
            return result;
        }

        /// <summary>
        /// Returns result class instance with error
        /// </summary>
        /// <typeparam name="T">Type of data property</typeparam>
        /// <param name="key">Error key</param>
        /// <param name="errorMessage">Error message</param>
        /// <returns></returns>
        public static Result<T> Error<T>(string key, string errorMessage)
        {
            var result = new Result<T>();
            result.AddError(key, errorMessage);
            return result;
        }

        /// <summary>
        /// Returns result class instance with error when exception is occurred
        /// </summary>
        /// <typeparam name="T">Type of data property</typeparam>
        /// <param name="errorMessage">Error message</param>
        /// <returns></returns>
        public static Result<T> Throw<T>(string errorMessage)
        {
            var result = new Result<T>();
            result.AddError(errorMessage, ErrorStatus.Server);
            return result;
        }

        /// <summary>
        /// Returns result class instance with error when exception is occurred
        /// </summary>
        /// <typeparam name="T">Type of data property</typeparam>
        /// <returns></returns>
        public static Result<T> Unauthorized<T>()
        {
            var result = new Result<T>();
            result.AddError("Unauthorized", ErrorStatus.UnAuthorized);
            return result;
        }
        #endregion
    }
}
