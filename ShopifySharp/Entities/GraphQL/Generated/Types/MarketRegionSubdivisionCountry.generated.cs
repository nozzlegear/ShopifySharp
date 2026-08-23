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
/// A country that a subdivision belongs to.
/// </summary>
public record MarketRegionSubdivisionCountry : IGraphQLObject
{
    /// <summary>
    /// The ISO code identifying the country.
    /// </summary>
    [JsonPropertyName("code")]
    public CountryCode? code { get; set; } = null;

    /// <summary>
    /// The name of the country.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}