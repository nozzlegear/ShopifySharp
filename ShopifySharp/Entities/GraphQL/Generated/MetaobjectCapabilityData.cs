#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Provides the capabilities of a metaobject.
/// </summary>
public record MetaobjectCapabilityData : IGraphQLObject
{
    /// <summary>
    /// The Online Store capability for this metaobject.
    /// </summary>
    [JsonPropertyName("onlineStore")]
    public MetaobjectCapabilityDataOnlineStore? onlineStore { get; set; } = null;

    /// <summary>
    /// The publishable capability for this metaobject.
    /// </summary>
    [JsonPropertyName("publishable")]
    public MetaobjectCapabilityDataPublishable? publishable { get; set; } = null;
}