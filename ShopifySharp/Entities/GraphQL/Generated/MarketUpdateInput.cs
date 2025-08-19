#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to update a market.
/// </summary>
public record MarketUpdateInput : GraphQLInputObject<MarketUpdateInput>
{
    /// <summary>
    /// Catalog IDs to include in the market.
    /// </summary>
    [JsonPropertyName("catalogsToAdd")]
    public ICollection<string>? catalogsToAdd { get; set; } = null;

    /// <summary>
    /// Catalog IDs to remove from the market.
    /// </summary>
    [JsonPropertyName("catalogsToDelete")]
    public ICollection<string>? catalogsToDelete { get; set; } = null;

    /// <summary>
    /// The conditions to update.
    /// </summary>
    [JsonPropertyName("conditions")]
    public MarketConditionsUpdateInput? conditions { get; set; } = null;

    /// <summary>
    /// Currency settings for the market.
    /// </summary>
    [JsonPropertyName("currencySettings")]
    public MarketCurrencySettingsUpdateInput? currencySettings { get; set; } = null;

    /// <summary>
    /// A unique identifier for the market. For example `"ca"`.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// Whether to update duplicate region or wildcard markets' status to draft.
    /// </summary>
    [JsonPropertyName("makeDuplicateUniqueMarketsDraft")]
    public bool? makeDuplicateUniqueMarketsDraft { get; set; } = null;

    /// <summary>
    /// The name of the market. Not shown to customers.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The strategy used to determine how prices are displayed to the customer.
    /// </summary>
    [JsonPropertyName("priceInclusions")]
    public MarketPriceInclusionsInput? priceInclusions { get; set; } = null;

    /// <summary>
    /// Remove any currency settings that are defined for the market.
    /// </summary>
    [JsonPropertyName("removeCurrencySettings")]
    public bool? removeCurrencySettings { get; set; } = null;

    /// <summary>
    /// The price inclusions to remove from the market.
    /// </summary>
    [JsonPropertyName("removePriceInclusions")]
    public bool? removePriceInclusions { get; set; } = null;

    /// <summary>
    /// The status of the market.
    /// </summary>
    [JsonPropertyName("status")]
    public MarketStatus? status { get; set; } = null;

    /// <summary>
    /// The web presences to add to the market.
    /// </summary>
    [JsonPropertyName("webPresencesToAdd")]
    public ICollection<string>? webPresencesToAdd { get; set; } = null;

    /// <summary>
    /// The web presences to remove from the market.
    /// </summary>
    [JsonPropertyName("webPresencesToDelete")]
    public ICollection<string>? webPresencesToDelete { get; set; } = null;
}