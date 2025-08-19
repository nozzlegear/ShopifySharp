#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The Online Store capability for the parent metaobject.
/// </summary>
public record MetaobjectCapabilityDataOnlineStore : IGraphQLObject
{
    /// <summary>
    /// The theme template used when viewing the metaobject in a store.
    /// </summary>
    [JsonPropertyName("templateSuffix")]
    public string? templateSuffix { get; set; } = null;
}