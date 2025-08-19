#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The compare-at price range of the product.
/// </summary>
public record ProductCompareAtPriceRange : IGraphQLObject
{
    /// <summary>
    /// The highest variant's compare-at price.
    /// </summary>
    [JsonPropertyName("maxVariantCompareAtPrice")]
    public MoneyV2? maxVariantCompareAtPrice { get; set; } = null;

    /// <summary>
    /// The lowest variant's compare-at price.
    /// </summary>
    [JsonPropertyName("minVariantCompareAtPrice")]
    public MoneyV2? minVariantCompareAtPrice { get; set; } = null;
}