namespace DotNetHelpers.Enums
{
    /// <summary>
    /// Enum for error types
    /// </summary>
    public enum ErrorStatus
    {
        /// <summary>
        /// Client error such as BadRequest
        /// </summary>
        Client,
        /// <summary>
        /// Servier error such as Internal error
        /// </summary>
        Server,
        /// <summary>
        /// Unauthorized error
        /// </summary>
        UnAuthorized,
        /// <summary>
        /// AccessDenied
        /// </summary>
        AccessDenied
    }
}
