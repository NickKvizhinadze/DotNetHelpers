using DotNetHelpers.Enums;
using System.Collections.Generic;

namespace DotNetHelpers.Models;

/// <summary>
/// Result class
/// </summary>
public class Result
{
    /// <summary>
    /// Error Code
    /// </summary>
    public ResultCode Code { get; protected set; }
    /// <summary>
    /// Errors
    /// </summary>
    public IEnumerable<Error> Errors { get; set; } = new List<Error>();

    /// <summary>
    /// If the result is successful
    /// </summary>
    public bool Succeeded => Code == ResultCode.Ok;
    
    /// <summary>
    /// If the entity is not found
    /// </summary>
    public bool EntityNotFound => Code == ResultCode.EntityNotFound;
    /// <summary>
    /// If there is an internal error
    /// </summary>
    public bool InternalError => Code == ResultCode.InternalError;
    /// <summary>
    /// If the request is bad
    /// </summary>
    public bool BadRequest => Code == ResultCode.BadRequest;
    /// <summary>
    /// If the request is forbidden
    /// </summary>
    public bool Forbidden => Code == ResultCode.Forbidden;


    public static Result SuccessResult() => new() { Code = ResultCode.Ok };
    public static Result EntityNotFoundResult() => new() { Code = ResultCode.EntityNotFound };
    public static Result InternalErrorResult() => new() { Code = ResultCode.InternalError };
    public static Result BadRequestResult() => new() { Code = ResultCode.BadRequest };
    public static Result ForbiddenResult() => new() { Code = ResultCode.Forbidden };
}

public class Result<T> : Result
{
    public T? Data { get; set; }


    public Result()
    {
    }

    public Result(Result result)
    {
        Code = result.Code;
        Errors = result.Errors;
    }
}

public class Error
{
    public string Code { get; private set; }
    public string Message { get; private set; }

    public Error(string code, string message)
    {
        Code = code;
        Message = message;
    }
}