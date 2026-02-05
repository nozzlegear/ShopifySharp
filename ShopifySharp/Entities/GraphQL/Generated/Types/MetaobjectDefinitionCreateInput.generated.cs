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
/// The input fields for creating a metaobject definition.
/// </summary>
public record MetaobjectDefinitionCreateInput : GraphQLInputObject<MetaobjectDefinitionCreateInput>
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
    public MetaobjectCapabilityCreateInput? capabilities { get; set; } = null;

    /// <summary>
    /// An administrative description of the definition.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The key of a field to reference as the display name for metaobjects of this type.
    /// </summary>
    [JsonPropertyName("displayNameKey")]
    public string? displayNameKey { get; set; } = null;

    /// <summary>
    /// A set of field definitions to create on this metaobject definition.
    /// </summary>
    [JsonPropertyName("fieldDefinitions")]
    public ICollection<MetaobjectFieldDefinitionCreateInput>? fieldDefinitions { get; set; } = null;

    /// <summary>
    /// A human-readable name for the definition. This can be changed at any time.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The type of the metaobject definition. This can't be changed.
    /// Must be 3-255 characters long and only contain alphanumeric, hyphen, and underscore characters.
    /// </summary>
    [JsonPropertyName("type")]
    public string? type { get; set; } = null;
}