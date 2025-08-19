#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A child of a combined listing.
/// </summary>
public record CombinedListingChild : IGraphQLObject
{
    /// <summary>
    /// The parent variant.
    /// </summary>
    [JsonPropertyName("parentVariant")]
    public ProductVariant? parentVariant { get; set; } = null;

    /// <summary>
    /// The child product.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;
}