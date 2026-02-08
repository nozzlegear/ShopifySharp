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
/// The renderable capability of a metaobject definition.
/// </summary>
public record MetaobjectCapabilitiesRenderable : IGraphQLObject
{
    /// <summary>
    /// The data associated with the renderable capability.
    /// </summary>
    [JsonPropertyName("data")]
    public MetaobjectCapabilityDefinitionDataRenderable? data { get; set; } = null;

    /// <summary>
    /// Indicates if the capability is enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;
}