#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Markets entitlement information.
/// </summary>
public record MarketsType : IGraphQLObject
{
    /// <summary>
    /// The entitlements for B2B markets.
    /// </summary>
    [JsonPropertyName("b2b")]
    public MarketsB2BEntitlement? b2b { get; set; } = null;

    /// <summary>
    /// The entitlements for region markets.
    /// </summary>
    [JsonPropertyName("regions")]
    public MarketsRegionsEntitlement? regions { get; set; } = null;

    /// <summary>
    /// The entitlements for retail markets.
    /// </summary>
    [JsonPropertyName("retail")]
    public MarketsRetailEntitlement? retail { get; set; } = null;

    /// <summary>
    /// The entitlements for themes.
    /// </summary>
    [JsonPropertyName("themes")]
    public MarketsThemesEntitlement? themes { get; set; } = null;
}