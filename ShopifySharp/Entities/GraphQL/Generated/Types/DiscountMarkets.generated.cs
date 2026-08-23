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
/// Markets where the discount is available.
/// </summary>
public record DiscountMarkets : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The list of markets where the discount is available.
    /// </summary>
    [JsonPropertyName("markets")]
    public MarketConnection? markets { get; set; } = null;

    /// <summary>
    /// The number of markets where the discount is available.
    /// </summary>
    [JsonPropertyName("marketsCount")]
    public int? marketsCount { get; set; } = null;
}