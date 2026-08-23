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
/// A subdivision of a country which comprises a market.
/// </summary>
public record MarketRegionSubdivision : IGraphQLObject, IMarketRegion, INode
{
    /// <summary>
    /// The ISO code identifying the subdivision.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// The country the subdivision belongs to.
    /// </summary>
    [JsonPropertyName("country")]
    public MarketRegionSubdivisionCountry? country { get; set; } = null;

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