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
/// Provides the capabilities of a metafield definition.
/// </summary>
public record MetafieldCapabilities : IGraphQLObject
{
    /// <summary>
    /// Indicate whether a metafield definition is configured for filtering.
    /// </summary>
    [JsonPropertyName("adminFilterable")]
    public MetafieldCapabilityAdminFilterable? adminFilterable { get; set; } = null;

    /// <summary>
    /// Indicate whether a metafield definition can be used as a smart collection condition.
    /// </summary>
    [JsonPropertyName("smartCollectionCondition")]
    public MetafieldCapabilitySmartCollectionCondition? smartCollectionCondition { get; set; } = null;

    /// <summary>
    /// Indicate whether the metafield values for a metafield definition are required to be unique.
    /// </summary>
    [JsonPropertyName("uniqueValues")]
    public MetafieldCapabilityUniqueValues? uniqueValues { get; set; } = null;
}