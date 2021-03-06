﻿using DotNetHelpers.Enums;
using System.Collections.Generic;

namespace DotNetHelpers.Models
{
    /// <summary>
    /// Result class
    /// </summary>
    public partial class Result
    {
        #region Fields

        private List<KeyValuePair<string, string>> _errors;

        #endregion

        #region Properties
        /// <summary>
        /// Indicates if method finished with success or fail
        /// </summary>
        public bool Succeeded => _errors == null || _errors.Count == 0;
        /// <summary>
        /// Errors
        /// </summary>
        public IReadOnlyList<KeyValuePair<string, string>> Errors => _errors;

        /// <summary>
        /// Error status
        /// </summary>
        public ErrorStatus ErrorStatus { get; private set; }

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
        /// <param name="errorStatus">Error status</param>
        public void AddError(string errorMessage, ErrorStatus errorStatus) =>
            AddError("Error", errorMessage, errorStatus);

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
        /// <param name="errorStatus">Error status</param>
        public void AddError(string key, string errorMessage, ErrorStatus errorStatus) =>
            AddError(new KeyValuePair<string, string>(key, errorMessage), errorStatus);

        /// <summary>
        /// Add new error
        /// </summary>
        /// <param name="error">Key and message for error</param>
        public void AddError(KeyValuePair<string, string> error) =>
            AddError(error, ErrorStatus.Client);

        /// <summary>
        /// Add new errors
        /// </summary>
        /// <param name="error">Key and message for error</param>
        /// <param name="errorStatus">Error status</param>
        public void AddError(KeyValuePair<string, string> error, ErrorStatus errorStatus)
        {
            if (ErrorStatus != errorStatus)
                ErrorStatus = errorStatus;
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
    }

    /// <summary>
    /// Result class
    /// </summary>
    /// <typeparam name="T">Type of result data</typeparam>
    public class Result<T> : Result
    {
        #region Constructor
        /// <summary>
        /// Empty Constructor
        /// </summary>
        public Result()
        {
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="data">Data</param>
        public Result(T data)
        {
            Data = data;
        }
        #endregion
        /// <summary>
        /// Data to return from method
        /// </summary>
        public T Data { get; set; }
    }
}