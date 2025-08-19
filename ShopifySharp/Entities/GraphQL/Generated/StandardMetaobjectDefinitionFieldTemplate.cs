#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A preset field definition on a standard metaobject definition template.
/// </summary>
public record StandardMetaobjectDefinitionFieldTemplate : IGraphQLObject
{
    /// <summary>
    /// The administrative description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The key owned by the definition after the definition has been enabled.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The human-readable name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The required status of the field within the object composition.
    /// </summary>
    [JsonPropertyName("required")]
    public bool? required { get; set; } = null;

    /// <summary>
    /// The associated [metafield definition
    /// type](https://shopify.dev/apps/metafields/definitions/types) that the
    /// metafield stores.
    /// </summary>
    [JsonPropertyName("type")]
    public MetafieldDefinitionType? type { get; set; } = null;

    /// <summary>
    /// The configured validations for the standard metafield definition.
    /// </summary>
    [JsonPropertyName("validations")]
    public ICollection<MetafieldDefinitionValidation>? validations { get; set; } = null;

    /// <summary>
    /// Whether metafields for the definition are by default visible using the Storefront API.
    /// </summary>
    [JsonPropertyName("visibleToStorefrontApi")]
    public bool? visibleToStorefrontApi { get; set; } = null;
}