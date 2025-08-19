#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for updating a metaobject field definition.
/// </summary>
public record MetaobjectFieldDefinitionUpdateInput : GraphQLInputObject<MetaobjectFieldDefinitionUpdateInput>
{
    /// <summary>
    /// An administrative description of the field.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The key of the field definition to update.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// A human-readable name for the field.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Whether metaobjects require a saved value for the field.
    /// </summary>
    [JsonPropertyName("required")]
    public bool? required { get; set; } = null;

    /// <summary>
    /// Custom validations that apply to values assigned to the field.
    /// </summary>
    [JsonPropertyName("validations")]
    public ICollection<MetafieldDefinitionValidationInput>? validations { get; set; } = null;
}