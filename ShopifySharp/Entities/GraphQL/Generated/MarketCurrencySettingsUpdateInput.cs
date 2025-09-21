#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields used to update the currency settings of a market.
/// </summary>
public record MarketCurrencySettingsUpdateInput : GraphQLInputObject<MarketCurrencySettingsUpdateInput>
{
    /// <summary>
    /// The currency which this market’s customers must use if local currencies are disabled.
    /// </summary>
    [JsonPropertyName("baseCurrency")]
    public CurrencyCode? baseCurrency { get; set; } = null;

    /// <summary>
    /// The manual exchange rate that will be used to convert shop currency prices. If
    /// null, then the automatic exchange rates will be used.
    /// </summary>
    [JsonPropertyName("baseCurrencyManualRate")]
    public decimal? baseCurrencyManualRate { get; set; } = null;

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