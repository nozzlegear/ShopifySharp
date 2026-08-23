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
/// The entitlements for catalogs.
/// </summary>
public record MarketsCatalogsEntitlement : IGraphQLObject
{
    /// <summary>
    /// Whether catalogs are enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;

    /// <summary>
    /// The maximum number of catalogs allowed.
    /// </summary>
    [JsonPropertyName("limit")]
    public int? limit { get; set; } = null;
}