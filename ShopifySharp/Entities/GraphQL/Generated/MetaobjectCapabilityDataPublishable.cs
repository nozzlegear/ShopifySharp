#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The publishable capability for the parent metaobject.
/// </summary>
public record MetaobjectCapabilityDataPublishable : IGraphQLObject
{
    /// <summary>
    /// The visibility status of this metaobject across all channels.
    /// </summary>
    [JsonPropertyName("status")]
    public MetaobjectStatus? status { get; set; } = null;
}