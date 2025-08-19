#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The entitlements for region markets.
/// </summary>
public record MarketsRegionsEntitlement : IGraphQLObject
{
    /// <summary>
    /// The entitlements for region market catalogs.
    /// </summary>
    [JsonPropertyName("catalogs")]
    public MarketsCatalogsEntitlement? catalogs { get; set; } = null;

    /// <summary>
    /// Whether region markets are enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;
}