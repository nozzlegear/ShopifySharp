#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Provides an object instance represented by a MetaobjectDefinition.
/// </summary>
public record Metaobject : IGraphQLUnionCase, IGraphQLObject, INode
{
    /// <summary>
    /// Metaobject capabilities for this Metaobject.
    /// </summary>
    [JsonPropertyName("capabilities")]
    public MetaobjectCapabilityData? capabilities { get; set; } = null;

    /// <summary>
    /// The app used to create the object.
    /// </summary>
    [JsonPropertyName("createdBy")]
    public App? createdBy { get; set; } = null;

    /// <summary>
    /// The app used to create the object.
    /// </summary>
    [JsonPropertyName("createdByApp")]
    public App? createdByApp { get; set; } = null;

    /// <summary>
    /// The staff member who created the metaobject.
    /// </summary>
    [JsonPropertyName("createdByStaff")]
    public StaffMember? createdByStaff { get; set; } = null;

    /// <summary>
    /// The MetaobjectDefinition that models this object type.
    /// </summary>
    [JsonPropertyName("definition")]
    public MetaobjectDefinition? definition { get; set; } = null;

    /// <summary>
    /// The preferred display name field value of the metaobject.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? displayName { get; set; } = null;

    /// <summary>
    /// The field for an object key, or null if the key has no field definition.
    /// </summary>
    [JsonPropertyName("field")]
    public MetaobjectField? field { get; set; } = null;

    /// <summary>
    /// All ordered fields of the metaobject with their definitions and values.
    /// </summary>
    [JsonPropertyName("fields")]
    public ICollection<MetaobjectField>? fields { get; set; } = null;

    /// <summary>
    /// The unique handle of the object, useful as a custom ID.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// List of back references metafields that belong to the resource.
    /// </summary>
    [JsonPropertyName("referencedBy")]
    public MetafieldRelationConnection? referencedBy { get; set; } = null;

    /// <summary>
    /// The staff member who created the metaobject.
    /// </summary>
    [JsonPropertyName("staffMember")]
    [Obsolete("Use `createdByStaff` instead.")]
    public StaffMember? staffMember { get; set; } = null;

    /// <summary>
    /// The recommended field to visually represent this metaobject. May be a file reference or color         field.
    /// </summary>
    [JsonPropertyName("thumbnailField")]
    public MetaobjectField? thumbnailField { get; set; } = null;

    /// <summary>
    /// The type of the metaobject.
    /// </summary>
    [JsonPropertyName("type")]
    public string? type { get; set; } = null;

    /// <summary>
    /// When the object was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? updatedAt { get; set; } = null;
}