#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The entitlements for B2B markets.
/// </summary>
public record MarketsB2BEntitlement : IGraphQLObject
{
    /// <summary>
    /// The entitlements for B2B market catalogs.
    /// </summary>
    [JsonPropertyName("catalogs")]
    public MarketsCatalogsEntitlement? catalogs { get; set; } = null;

    /// <summary>
    /// Whether B2B markets are enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;
}