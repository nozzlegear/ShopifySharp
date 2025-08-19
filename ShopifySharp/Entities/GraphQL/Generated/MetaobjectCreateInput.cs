#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for creating a metaobject.
/// </summary>
public record MetaobjectCreateInput : GraphQLInputObject<MetaobjectCreateInput>
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
    /// A unique handle for the metaobject. This value is auto-generated when omitted.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// The type of the metaobject. Must match an existing metaobject definition type.
    /// </summary>
    [JsonPropertyName("type")]
    public string? type { get; set; } = null;
}