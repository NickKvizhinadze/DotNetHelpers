using System.Collections.Generic;
using DotNetHelpers.Models;

namespace DotNetHelpers.Extentions;

/// <summary>
/// Result extensions
/// </summary>
public static class ResultExtensions
{
    #region Public Methods

    /// <summary>
    /// Add error to result
    /// </summary>
    /// <param name="result">Result model</param>
    /// <param name="message">Error message</param>
    /// <param name="code">Error code</param>
    /// <returns></returns>
    public static Result WithError(this Result result, string message, string code = "operation_failure")
    {
        return result.AddError(code, message);
    }

    /// <summary>
    /// Add error to result
    /// </summary>
    /// <param name="result">Result model</param>
    /// <param name="error">Error model</param>
    /// <returns></returns>
    public static Result WithError(this Result result, Error error)
    {
        return result.AddError(error);
    }

    /// <summary>
    /// Add error to result
    /// </summary>
    /// <param name="result">Result model</param>
    /// <param name="messages">List of error messages</param>
    /// <param name="code">Error code</param>
    /// <returns></returns>
    public static Result WithErrors(this Result result, IEnumerable<string> messages,
        string code = "operation_failure")
    {
        return result.AddErrors(code, messages);
    }

    /// <summary>
    /// Add error to result
    /// </summary>
    /// <param name="result">Result model</param>
    /// <param name="errors">List of errors</param>
    /// <returns></returns>
    public static Result WithErrors(this Result result, IEnumerable<Error> errors)
    {
        return result.AddErrors(errors);
    }

    /// <summary>
    /// Add error to result
    /// </summary>
    /// <param name="result">Result model</param>
    /// <param name="message">Error message</param>
    /// <param name="code">Error code</param>
    /// <typeparam name="T">Type of result data</typeparam>
    /// <returns></returns>
    public static Result<T> WithError<T>(this Result result, string message,
        string code = "operation_failure")
    {
        return new Result<T>(result).AddError(code, message);
    }


    /// <summary>
    /// Add error to result
    /// </summary>
    /// <param name="result">Result model</param>
    /// <param name="error">Error model</param>
    /// <typeparam name="T">Type of result data</typeparam>
    /// <returns></returns>
    public static Result<T> WithError<T>(this Result<T> result, Error error)
    {
        return new Result<T>(result).AddError(error);
    }

    /// <summary>
    /// Add error to result
    /// </summary>
    /// <param name="result">Result model</param>
    /// <param name="messages">List of error messages</param>
    /// <param name="code">Error code</param>
    /// <typeparam name="T">Type of result data</typeparam>
    /// <returns></returns>
    public static Result<T> WithErrors<T>(this Result result, IEnumerable<string> messages,
        string code = "operation_failure")
    {
        return new Result<T>(result).AddErrors(code, messages);
    }

    /// <summary>
    /// Add error to result
    /// </summary>
    /// <param name="result">Result model</param>
    /// <param name="errors">List of errors</param>
    /// <typeparam name="T">Type of result data</typeparam>
    /// <returns></returns>
    public static Result<T> WithErrors<T>(this Result result, IEnumerable<Error> errors)
    {
        return new Result<T>(result).AddErrors(errors);
    }

    /// <summary>
    /// Add data to result
    /// </summary>
    /// <param name="result">Result model</param>
    /// <param name="data">Data</param>
    /// <typeparam name="T">Type of result data</typeparam>
    /// <returns></returns>
    public static Result<T> WithData<T>(this Result result, T data)
    {
        return new Result<T>(result).SetData(data);
    }

    
    /// <summary>
    /// Add empty data type to result
    /// </summary>
    /// <param name="result">Result model</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static Result<T> WithEmptyData<T>(this Result result)
    {
        return new Result<T>(result);
    }
    #endregion

    #region Private Methods
    private static Result AddError(this Result result, string code, string message)
    {
        var error = new Error(code, message);
        result.Errors = new List<Error> { error };
        return result;
    }
    
    private static Result AddError(this Result result, Error error)
    {
        result.Errors = new List<Error> { error };
        return result;
    }

    private static Result AddErrors(this Result result, string code, IEnumerable<string> messages)
    {
        var errors = new List<Error>();
        foreach (var message in messages)
            errors.Add(new Error(code, message));

        result.Errors = errors;
        return result;
    }

    private static Result AddErrors(this Result result, IEnumerable<Error> errors)
    {
        result.Errors = errors;
        return result;
    }

    private static Result<T> AddError<T>(this Result<T> result, string code, string message)
    {
        var error = new Error(code, message);
        result.Errors = new List<Error> { error };
        return result;
    }

    private static Result<T> AddError<T>(this Result<T> result, Error error)
    {
        result.Errors = new List<Error> { error };
        return result;
    }

    private static Result<T> AddErrors<T>(this Result<T> result, string code, IEnumerable<string> messages)
    {
        var errors = new List<Error>();
        foreach (var message in messages)
            errors.Add(new Error(code, message));

        result.Errors = errors;
        return result;
    }

    private static Result<T> AddErrors<T>(this Result<T> result, IEnumerable<Error> errors)
    {
        result.Errors = errors;
        return result;
    }

    private static Result<T> SetData<T>(this Result<T> result, T data)
    {
        result.Data = data;
        return result;
    }

    #endregion
}