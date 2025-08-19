#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The resolved price inclusivity attributes.
/// </summary>
public record ResolvedPriceInclusivity : IGraphQLObject
{
    /// <summary>
    /// Whether duties are included in the price.
    /// </summary>
    [JsonPropertyName("dutiesIncluded")]
    public bool? dutiesIncluded { get; set; } = null;

    /// <summary>
    /// Whether taxes are included in the price.
    /// </summary>
    [JsonPropertyName("taxesIncluded")]
    public bool? taxesIncluded { get; set; } = null;
}