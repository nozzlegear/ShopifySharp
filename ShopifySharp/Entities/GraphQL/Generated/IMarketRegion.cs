#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A geographic region which comprises a market.
/// </summary>
public interface IMarketRegion : IGraphQLObject
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }

    /// <summary>
    /// The name of the region.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; }
}