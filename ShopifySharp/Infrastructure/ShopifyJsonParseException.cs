#nullable enable
using System;
using System.Text.Json;

namespace ShopifySharp;

[Serializable]
public class ShopifyJsonParseException : ShopifyException
{
    public ShopifyJsonParseException(string message,
        JsonProperty? sourceJson,
        string? requestId = null,
        ShopifyException? innerException = null) : base(message, innerException)
    {
        JsonElement = sourceJson?.Value.Clone();
        RequestId = requestId;
    }

    /// <summary>
    /// The element that caused the exception. May be null if it was not possible to capture the element.
    /// </summary>
    public JsonElement? JsonElement { get; }

    public string? RequestId { get; }
}
