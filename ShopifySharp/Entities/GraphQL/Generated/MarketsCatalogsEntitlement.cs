#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The entitlements for catalogs.
/// </summary>
public record MarketsCatalogsEntitlement : IGraphQLObject
{
    /// <summary>
    /// Whether catalogs are enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;
}