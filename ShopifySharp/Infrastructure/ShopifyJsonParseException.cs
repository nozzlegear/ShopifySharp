#nullable enable
using System;
using System.Text.Json;

namespace ShopifySharp;

[Serializable]
public class ShopifyJsonParseException(
    string message,
    string? jsonPropertyName = null,
    string? requestId = null,
    Exception? innerException = null)
    : ShopifyException(message, innerException)
{
    /// <summary>
    /// The name of the JSON property that caused the exception. May be null if it was not possible to capture the name.
    /// </summary>
    public string? JsonPropertyName { get; } = jsonPropertyName;

    /// <summary>
    /// The request ID associated with the exception, if available.
    /// </summary>
    public string? RequestId { get; } = requestId;
}
