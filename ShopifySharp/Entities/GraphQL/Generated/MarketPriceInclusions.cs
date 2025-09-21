#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The inclusive pricing strategy for a market.
/// </summary>
public record MarketPriceInclusions : IGraphQLObject
{
    /// <summary>
    /// The inclusive duties pricing strategy of the market. This determines if prices include duties.
    /// </summary>
    [JsonPropertyName("inclusiveDutiesPricingStrategy")]
    public InclusiveDutiesPricingStrategy? inclusiveDutiesPricingStrategy { get; set; } = null;

    /// <summary>
    /// The inclusive tax pricing strategy of the market. This determines if prices include taxes.
    /// </summary>
    [JsonPropertyName("inclusiveTaxPricingStrategy")]
    public InclusiveTaxPricingStrategy? inclusiveTaxPricingStrategy { get; set; } = null;
}