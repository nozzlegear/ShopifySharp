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
/// Standard metaobject definition templates provide preset configurations to create metaobject definitions.
/// </summary>
public record StandardMetaobjectDefinitionTemplate : IGraphQLObject
{
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
    /// The capabilities of the metaobject definition.
    /// </summary>
    [JsonPropertyName("enabledCapabilities")]
    public ICollection<StandardMetaobjectCapabilityTemplate>? enabledCapabilities { get; set; } = null;

    /// <summary>
    /// Templates for the associated field definitions.
    /// </summary>
    [JsonPropertyName("fieldDefinitions")]
    public ICollection<StandardMetaobjectDefinitionFieldTemplate>? fieldDefinitions { get; set; } = null;

    /// <summary>
    /// The human-readable name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The namespace owned by the definition after the definition has been enabled.
    /// </summary>
    [JsonPropertyName("type")]
    public string? type { get; set; } = null;
}