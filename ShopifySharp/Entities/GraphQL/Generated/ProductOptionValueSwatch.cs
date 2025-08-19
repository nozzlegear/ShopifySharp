#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A swatch associated with a product option value.
/// </summary>
public record ProductOptionValueSwatch : IGraphQLObject
{
    /// <summary>
    /// The color representation of the swatch.
    /// </summary>
    [JsonPropertyName("color")]
    public string? color { get; set; } = null;

    /// <summary>
    /// An image representation of the swatch.
    /// </summary>
    [JsonPropertyName("image")]
    public MediaImage? image { get; set; } = null;
}