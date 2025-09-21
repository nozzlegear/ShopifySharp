#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for creating a metaobject field definition.
/// </summary>
public record MetaobjectFieldDefinitionCreateInput : GraphQLInputObject<MetaobjectFieldDefinitionCreateInput>
{
    /// <summary>
    /// An administrative description of the field.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The key of the new field definition. This can't be changed.
    /// Must be 2-64 characters long and only contain alphanumeric, hyphen, and underscore characters.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// A human-readable name for the field. This can be changed at any time.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Whether metaobjects require a saved value for the field.
    /// </summary>
    [JsonPropertyName("required")]
    public bool? required { get; set; } = null;

    /// <summary>
    /// The metafield type applied to values of the field.
    /// </summary>
    [JsonPropertyName("type")]
    public string? type { get; set; } = null;

    /// <summary>
    /// Custom validations that apply to values assigned to the field.
    /// </summary>
    [JsonPropertyName("validations")]
    public ICollection<MetafieldDefinitionValidationInput>? validations { get; set; } = null;
}