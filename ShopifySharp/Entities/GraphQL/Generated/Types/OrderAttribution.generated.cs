#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The attribution details for an order.
/// </summary>
public record OrderAttribution : IGraphQLObject
{
    /// <summary>
    /// The display name of the attribution source.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? displayName { get; set; } = null;

    /// <summary>
    /// An identifier for the attribution source.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// Sanitized SVG content used as the attribution source icon.
    /// </summary>
    [JsonPropertyName("icon")]
    public string? icon { get; set; } = null;
}