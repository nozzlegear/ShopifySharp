#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents an image for a Shop Pay payment request line item.
/// </summary>
public record ShopPayPaymentRequestImage : IGraphQLObject
{
    /// <summary>
    /// The alt text of the image.
    /// </summary>
    [JsonPropertyName("alt")]
    public string? alt { get; set; } = null;

    /// <summary>
    /// The source URL of the image.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}