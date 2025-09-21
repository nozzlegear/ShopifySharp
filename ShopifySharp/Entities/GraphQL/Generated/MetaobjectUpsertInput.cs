#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for upserting a metaobject.
/// </summary>
public record MetaobjectUpsertInput : GraphQLInputObject<MetaobjectUpsertInput>
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
    /// The handle of the metaobject.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;
}