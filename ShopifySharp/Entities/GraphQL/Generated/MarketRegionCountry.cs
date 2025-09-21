#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A country which comprises a market.
/// </summary>
public record MarketRegionCountry : IGraphQLObject, IMarketRegion, INode
{
    /// <summary>
    /// The ISO code identifying the country.
    /// </summary>
    [JsonPropertyName("code")]
    public CountryCode? code { get; set; } = null;

    /// <summary>
    /// The currency which this country uses given its market settings.
    /// </summary>
    [JsonPropertyName("currency")]
    public CurrencySetting? currency { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The name of the region.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}