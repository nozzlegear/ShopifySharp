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
/// Capabilities available for a metaobject field definition.
/// </summary>
public record MetaobjectFieldDefinitionCapabilities : IGraphQLObject
{
    /// <summary>
    /// Indicate whether a metaobject field definition is configured for filtering.
    /// </summary>
    [JsonPropertyName("adminFilterable")]
    public MetaobjectFieldCapabilityAdminFilterable? adminFilterable { get; set; } = null;
}