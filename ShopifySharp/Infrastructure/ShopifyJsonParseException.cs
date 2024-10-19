#nullable enable
using System;
using System.Text.Json;

namespace ShopifySharp;

[Serializable]
public class ShopifyJsonParseException(
    string message,
    string? jsonPropertyName,
    string? requestId = null,
    ShopifyException? innerException = null)
    : ShopifyException(message, innerException)
{
    /// <summary>
    /// The name of the json property that caused the exception. May be null if it was not possible to capture the name.
    /// </summary>
    public string? JsonPropertyName { get; } = jsonPropertyName;

    public string? RequestId { get; } = requestId;
}
