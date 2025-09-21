#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A market's currency settings.
/// </summary>
public record MarketCurrencySettings : IGraphQLObject
{
    /// <summary>
    /// The currency which this market's customers must use if local currencies are disabled.
    /// </summary>
    [JsonPropertyName("baseCurrency")]
    public CurrencySetting? baseCurrency { get; set; } = null;

    /// <summary>
    /// Whether or not local currencies are enabled. If enabled, then prices will
    /// be converted to give each customer the best experience based on their
    /// region. If disabled, then all customers in this market will see prices
    /// in the market's base currency.
    /// </summary>
    [JsonPropertyName("localCurrencies")]
    public bool? localCurrencies { get; set; } = null;

    /// <summary>
    /// Whether or not rounding is enabled on multi-currency prices.
    /// </summary>
    [JsonPropertyName("roundingEnabled")]
    public bool? roundingEnabled { get; set; } = null;
}