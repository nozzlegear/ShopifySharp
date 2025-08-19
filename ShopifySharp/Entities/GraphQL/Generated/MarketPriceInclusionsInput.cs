#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to create a price inclusion.
/// </summary>
public record MarketPriceInclusionsInput : GraphQLInputObject<MarketPriceInclusionsInput>
{
    /// <summary>
    /// The inclusive duties pricing strategy for the market.
    /// </summary>
    [JsonPropertyName("dutiesPricingStrategy")]
    public InclusiveDutiesPricingStrategy? dutiesPricingStrategy { get; set; } = null;

    /// <summary>
    /// The inclusive tax pricing strategy for the market.
    /// </summary>
    [JsonPropertyName("taxPricingStrategy")]
    public InclusiveTaxPricingStrategy? taxPricingStrategy { get; set; } = null;
}