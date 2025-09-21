#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The entitlements for retail markets.
/// </summary>
public record MarketsRetailEntitlement : IGraphQLObject
{
    /// <summary>
    /// The entitlements for retail market catalogs.
    /// </summary>
    [JsonPropertyName("catalogs")]
    public MarketsCatalogsEntitlement? catalogs { get; set; } = null;

    /// <summary>
    /// Whether retail markets are enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;
}