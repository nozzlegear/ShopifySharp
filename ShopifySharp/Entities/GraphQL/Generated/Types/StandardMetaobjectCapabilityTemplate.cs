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
/// Describes a capability that is enabled on a Metaobject Definition.
/// </summary>
public record StandardMetaobjectCapabilityTemplate : IGraphQLObject
{
    /// <summary>
    /// The type of capability that's enabled for the metaobject definition.
    /// </summary>
    [JsonPropertyName("capabilityType")]
    public MetaobjectCapabilityType? capabilityType { get; set; } = null;
}