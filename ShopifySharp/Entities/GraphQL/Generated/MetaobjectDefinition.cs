#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Provides the definition of a generic object structure composed of metafields.
/// </summary>
public record MetaobjectDefinition : IGraphQLObject, INode
{
    /// <summary>
    /// Access configuration for the metaobject definition.
    /// </summary>
    [JsonPropertyName("access")]
    public MetaobjectAccess? access { get; set; } = null;

    /// <summary>
    /// The capabilities of the metaobject definition.
    /// </summary>
    [JsonPropertyName("capabilities")]
    public MetaobjectCapabilities? capabilities { get; set; } = null;

    /// <summary>
    /// The app used to create the metaobject definition.
    /// </summary>
    [JsonPropertyName("createdByApp")]
    public App? createdByApp { get; set; } = null;

    /// <summary>
    /// The staff member who created the metaobject definition.
    /// </summary>
    [JsonPropertyName("createdByStaff")]
    public StaffMember? createdByStaff { get; set; } = null;

    /// <summary>
    /// The administrative description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The key of a field to reference as the display name for each object.
    /// </summary>
    [JsonPropertyName("displayNameKey")]
    public string? displayNameKey { get; set; } = null;

    /// <summary>
    /// The fields defined for this object type.
    /// </summary>
    [JsonPropertyName("fieldDefinitions")]
    public ICollection<MetaobjectFieldDefinition>? fieldDefinitions { get; set; } = null;

    /// <summary>
    /// Whether this metaobject definition has field whose type can visually represent
    /// a metaobject with        the `thumbnailField`.
    /// </summary>
    [JsonPropertyName("hasThumbnailField")]
    public bool? hasThumbnailField { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// A paginated connection to the metaobjects associated with the definition.
    /// </summary>
    [JsonPropertyName("metaobjects")]
    public MetaobjectConnection? metaobjects { get; set; } = null;

    /// <summary>
    /// The count of metaobjects created for the definition.
    /// </summary>
    [JsonPropertyName("metaobjectsCount")]
    public int? metaobjectsCount { get; set; } = null;

    /// <summary>
    /// The human-readable name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The standard metaobject template associated with the definition.
    /// </summary>
    [JsonPropertyName("standardTemplate")]
    public StandardMetaobjectDefinitionTemplate? standardTemplate { get; set; } = null;

    /// <summary>
    /// The type of the object definition. Defines the namespace of associated metafields.
    /// </summary>
    [JsonPropertyName("type")]
    public string? type { get; set; } = null;
}