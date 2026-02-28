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
/// Defines a field for a MetaobjectDefinition with properties
/// such as the field's data type and validations.
/// </summary>
public record MetaobjectFieldDefinition : IGraphQLObject
{
    /// <summary>
    /// Capabilities available for this metaobject field definition.
    /// </summary>
    [JsonPropertyName("capabilities")]
    public MetaobjectFieldDefinitionCapabilities? capabilities { get; set; } = null;

    /// <summary>
    /// The administrative description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// A key name used to identify the field within the metaobject composition.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The human-readable name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Required status of the field within the metaobject composition.
    /// </summary>
    [JsonPropertyName("required")]
    public bool? required { get; set; } = null;

    /// <summary>
    /// The type of data that the field stores.
    /// </summary>
    [JsonPropertyName("type")]
    public MetafieldDefinitionType? type { get; set; } = null;

    /// <summary>
    /// A list of [validation options](https://shopify.dev/apps/metafields/definitions/validation) for
    /// the field. For example, a field with the type `date` can set a minimum date requirement.
    /// </summary>
    [JsonPropertyName("validations")]
    public ICollection<MetafieldDefinitionValidation>? validations { get; set; } = null;
}