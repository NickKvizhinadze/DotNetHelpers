using System.Collections.Generic;

namespace DotNetHelpers.Models
{
    public class Result
    {
        #region Fields

        private List<KeyValuePair<string, string>> _errors;

        #endregion

        #region Properties

        public bool Succeeded => _errors == null || _errors.Count == 0;
        public IReadOnlyList<KeyValuePair<string, string>> Errors => _errors;
        public bool IsException { get; private set; }

        #endregion

        #region Methods
        /// <summary>
        /// Add new error
        /// </summary>
        /// <param name="errorMessage">Error message</param>
        public void AddError(string errorMessage) =>
            AddError("Error", errorMessage);

        /// <summary>
        /// Add new error
        /// </summary>
        /// <param name="errorMessage">Error message</param>
        /// <param name="isException">True if exception is occurred</param>
        public void AddError(string errorMessage, bool isException) =>
            AddError("Error", errorMessage, isException);

        /// <summary>
        /// Add new error
        /// </summary>
        /// <param name="key">Key for error</param>
        /// <param name="errorMessage">Error message</param>
        public void AddError(string key, string errorMessage) =>
            AddError(new KeyValuePair<string, string>(key, errorMessage));

        /// <summary>
        /// Add new error
        /// </summary>
        /// <param name="key">Key for error</param>
        /// <param name="errorMessage">Error message</param>
        /// <param name="isException">True if exception is occurred</param>
        public void AddError(string key, string errorMessage, bool isException) =>
            AddError(new KeyValuePair<string, string>(key, errorMessage), isException);

        /// <summary>
        /// Add new error
        /// </summary>
        /// <param name="error">Key and message for error</param>
        public void AddError(KeyValuePair<string, string> error) =>
            AddError(error, false);

        /// <summary>
        /// Add new errors
        /// </summary>
        /// <param name="error">Key and message for error</param>
        /// <param name="isException">True if exception is occurred</param>
        public void AddError(KeyValuePair<string, string> error, bool isException = false)
        {
            if (IsException != isException)
                IsException = isException;
            if (_errors == null)
                _errors = new List<KeyValuePair<string, string>>();
            _errors.Add(error);
        }

        /// <summary>
        /// Add new errors
        /// </summary>
        /// <param name="errorMessages">List of error message</param>
        public void AddErrors(List<string> errorMessages)
        {
            foreach (var errorMessage in errorMessages)
                AddError(errorMessage);
        }

        /// <summary>
        /// Add new errors
        /// </summary>
        /// <param name="errors">Dictionary of errors Key and message</param>
        public void AddError(Dictionary<string, string> errors)
        {
            foreach (var error in errors)
                AddError(error.Key, error.Value);
        }

        /// <summary>
        /// Add new error
        /// </summary>
        /// <param name="errors">List of errors Key and message</param>
        public void AddErrors(IEnumerable<KeyValuePair<string, string>> errors)
        {
            foreach (var error in errors)
                AddError(error.Key, error.Value);
        }

        #endregion

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
        /// Returns result class instance with error when exception is occurred
        /// </summary>
        /// <param name="errorMessage">Error message</param>
        /// <returns></returns>
        public static Result Throw(string errorMessage)
        {
            var result = new Result();
            result.AddError(errorMessage, true);
            return result;
        }

        /// <summary>
        /// Returns result class instance with success
        /// </summary>
        /// <typeparam name="T">Type of data property</typeparam>
        /// <returns></returns>
        public static Result Success<T>() => new Result<T>();

        /// <summary>
        /// Returns result class instance with error
        /// </summary>
        /// <typeparam name="T">Type of data property</typeparam>
        /// <param name="errorMessage">Error message</param>
        /// <returns></returns>
        public static Result Error<T>(string errorMessage)
        {
            var result = new Result<T>();
            result.AddError(errorMessage);
            return result;
        }

        /// <summary>
        /// Returns result class instance with error when exception is occurred
        /// </summary>
        /// <typeparam name="T">Type of data property</typeparam>
        /// <param name="errorMessage">Error message</param>
        /// <returns></returns>
        public static Result Throw<T>(string errorMessage)
        {
            var result = new Result<T>();
            result.AddError(errorMessage, true);
            return result;
        }
        #endregion
    }

    public class Result<T> : Result
    {
        public T Data { get; set; }
    }
}