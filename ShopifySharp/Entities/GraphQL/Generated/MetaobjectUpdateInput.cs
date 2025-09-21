#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for updating a metaobject.
/// </summary>
public record MetaobjectUpdateInput : GraphQLInputObject<MetaobjectUpdateInput>
{
    /// <summary>
    /// Capabilities for the metaobject.
    /// </summary>
    [JsonPropertyName("capabilities")]
    public MetaobjectCapabilityDataInput? capabilities { get; set; } = null;

    /// <summary>
    /// Values for fields. These are mapped by key to fields of the metaobject definition.
    /// </summary>
    [JsonPropertyName("fields")]
    public ICollection<MetaobjectFieldInput>? fields { get; set; } = null;

    /// <summary>
    /// A unique handle for the metaobject.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// Whether to create a redirect for the metaobject.
    /// </summary>
    [JsonPropertyName("redirectNewHandle")]
    public bool? redirectNewHandle { get; set; } = null;
}