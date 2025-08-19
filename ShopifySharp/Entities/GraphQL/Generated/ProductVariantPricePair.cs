#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The compare-at price and price of a variant sharing a currency.
/// </summary>
public record ProductVariantPricePair : IGraphQLObject
{
    /// <summary>
    /// The compare-at price of the variant with associated currency.
    /// </summary>
    [JsonPropertyName("compareAtPrice")]
    public MoneyV2? compareAtPrice { get; set; } = null;

    /// <summary>
    /// The price of the variant with associated currency.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyV2? price { get; set; } = null;
}