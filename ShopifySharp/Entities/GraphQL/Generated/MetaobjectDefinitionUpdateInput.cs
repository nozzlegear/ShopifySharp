#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for updating a metaobject definition.
/// </summary>
public record MetaobjectDefinitionUpdateInput : GraphQLInputObject<MetaobjectDefinitionUpdateInput>
{
    /// <summary>
    /// Access configuration for the metaobjects created with this definition.
    /// </summary>
    [JsonPropertyName("access")]
    public MetaobjectAccessInput? access { get; set; } = null;

    /// <summary>
    /// The capabilities of the metaobject definition.
    /// </summary>
    [JsonPropertyName("capabilities")]
    public MetaobjectCapabilityUpdateInput? capabilities { get; set; } = null;

    /// <summary>
    /// An administrative description of the definition.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The key of a metafield to reference as the display name for objects of this type.
    /// </summary>
    [JsonPropertyName("displayNameKey")]
    public string? displayNameKey { get; set; } = null;

    /// <summary>
    /// A set of operations for modifying field definitions.
    /// </summary>
    [JsonPropertyName("fieldDefinitions")]
    public ICollection<MetaobjectFieldDefinitionOperationInput>? fieldDefinitions { get; set; } = null;

    /// <summary>
    /// A human-readable name for the definition.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Whether the field order should be reset while updating.
    /// If `true`, then the order is assigned based on submitted fields followed by alphabetized field omissions.
    /// If `false`, then no changes are made to the existing field order and new fields are appended at the end.
    /// </summary>
    [JsonPropertyName("resetFieldOrder")]
    public bool? resetFieldOrder { get; set; } = null;
}