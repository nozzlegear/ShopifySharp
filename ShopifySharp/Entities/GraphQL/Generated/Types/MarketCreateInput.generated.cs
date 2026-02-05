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
/// The input fields required to create a market.
/// </summary>
public record MarketCreateInput : GraphQLInputObject<MarketCreateInput>
{
    /// <summary>
    /// Catalog IDs to include in the market.
    /// </summary>
    [JsonPropertyName("catalogs")]
    public ICollection<string>? catalogs { get; set; } = null;

    /// <summary>
    /// The conditions that apply to the market.
    /// </summary>
    [JsonPropertyName("conditions")]
    public MarketConditionsInput? conditions { get; set; } = null;

    /// <summary>
    /// Currency settings for the market.
    /// </summary>
    [JsonPropertyName("currencySettings")]
    public MarketCurrencySettingsUpdateInput? currencySettings { get; set; } = null;

    /// <summary>
    /// A unique identifier for the market. For example `"ca"`.
    /// If the handle isn't provided, then the handle is auto-generated based on the country or name.
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
    /// The status of the market.
    /// </summary>
    [JsonPropertyName("status")]
    public MarketStatus? status { get; set; } = null;

    /// <summary>
    /// Web presence IDs to include in the market.
    /// </summary>
    [JsonPropertyName("webPresences")]
    public ICollection<string>? webPresences { get; set; } = null;
}