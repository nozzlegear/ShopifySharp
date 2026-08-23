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
/// The input fields used to create a price inclusion.
/// </summary>
public record MarketPriceInclusionsInput : GraphQLInputObject<MarketPriceInclusionsInput>
{
    /// <summary>
    /// Whether adaptive pricing is enabled for the market. Only applicable for
    /// Markets with Managed Market enabled. When enabled, forces a state of
    /// `INCLUDES_TAXES_IN_PRICE_BASED_ON_COUNTRY`, `INCLUDE_DUTIES_IN_PRICE`, and
    /// `DDP`. When disabled, defaults to `INCLUDES_TAXES_IN_PRICE_BASED_ON_COUNTRY`,
    /// `ADD_DUTIES_AT_CHECKOUT`, and `DDP` unless otherwise specified.
    /// </summary>
    [JsonPropertyName("adaptivePricingEnabled")]
    public bool? adaptivePricingEnabled { get; set; } = null;

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