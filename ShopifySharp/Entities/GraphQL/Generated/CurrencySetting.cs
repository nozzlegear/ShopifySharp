#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A setting for a presentment currency.
/// </summary>
public record CurrencySetting : IGraphQLObject
{
    /// <summary>
    /// The currency's ISO code.
    /// </summary>
    [JsonPropertyName("currencyCode")]
    public CurrencyCode? currencyCode { get; set; } = null;

    /// <summary>
    /// The full name of the currency.
    /// </summary>
    [JsonPropertyName("currencyName")]
    public string? currencyName { get; set; } = null;

    /// <summary>
    /// Whether the currency is enabled or not. An enabled currency setting is visible
    /// to buyers and allows orders to be generated with that currency as presentment.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;

    /// <summary>
    /// The manual rate, if enabled, that applies to this currency when converting
    /// from shop currency. This rate is specific to the associated market's currency setting.
    /// </summary>
    [JsonPropertyName("manualRate")]
    public decimal? manualRate { get; set; } = null;

    /// <summary>
    /// The date and time when the active exchange rate for the currency was last
    /// modified. It can be the automatic rate's creation date, or the manual rate's
    /// last updated at date if active.
    /// </summary>
    [JsonPropertyName("rateUpdatedAt")]
    public DateTime? rateUpdatedAt { get; set; } = null;
}