#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The Online Store capability of a metaobject definition.
/// </summary>
public record MetaobjectCapabilitiesOnlineStore : IGraphQLObject
{
    /// <summary>
    /// The data associated with the Online Store capability.
    /// </summary>
    [JsonPropertyName("data")]
    public MetaobjectCapabilityDefinitionDataOnlineStore? data { get; set; } = null;

    /// <summary>
    /// Indicates if the capability is enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;
}