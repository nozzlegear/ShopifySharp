#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The price of a product variant in a specific country.
/// Prices vary between countries.
/// </summary>
public record ProductVariantContextualPricing : IGraphQLObject
{
    /// <summary>
    /// The final compare-at price after all adjustments are applied.
    /// </summary>
    [JsonPropertyName("compareAtPrice")]
    public MoneyV2? compareAtPrice { get; set; } = null;

    /// <summary>
    /// The final price after all adjustments are applied.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyV2? price { get; set; } = null;

    /// <summary>
    /// A list of quantity breaks for the product variant.
    /// </summary>
    [JsonPropertyName("quantityPriceBreaks")]
    public QuantityPriceBreakConnection? quantityPriceBreaks { get; set; } = null;

    /// <summary>
    /// The quantity rule applied for a given context.
    /// </summary>
    [JsonPropertyName("quantityRule")]
    public QuantityRule? quantityRule { get; set; } = null;

    /// <summary>
    /// The unit price value for the given context based on the variant measurement.
    /// </summary>
    [JsonPropertyName("unitPrice")]
    public MoneyV2? unitPrice { get; set; } = null;
}