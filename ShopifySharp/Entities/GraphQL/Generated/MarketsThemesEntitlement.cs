#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The entitlements for themes.
/// </summary>
public record MarketsThemesEntitlement : IGraphQLObject
{
    /// <summary>
    /// Whether themes are enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;
}