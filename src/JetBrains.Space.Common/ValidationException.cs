using System.Net;
using JetBrains.Annotations;

namespace JetBrains.Space.Common;

/// <summary>
/// Represents an exception thrown when validation fails.
/// </summary>
[PublicAPI]
public class ValidationException 
    : ResourceException
{
    /// <inheritdoc />
    public ValidationException()
    {
    }

    /// <inheritdoc />
    public ValidationException(string message) 
        : base(message)
    {
    }

    /// <inheritdoc />
    public ValidationException(string message, HttpStatusCode statusCode, string? response) 
        : base(message, statusCode, response)
    {
    }
}