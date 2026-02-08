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
/// Standard metafield definition templates provide preset configurations to create metafield definitions.
/// Each template has a specific namespace and key that we've reserved to have specific meanings for common use cases.
/// Refer to the [list of standard metafield definitions](https://shopify.dev/apps/metafields/definitions/standard-definitions).
/// </summary>
public record StandardMetafieldDefinitionTemplate : IGraphQLObject, INode
{
    /// <summary>
    /// The description of the standard metafield definition.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The key owned by the definition after the definition has been activated.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The human-readable name for the standard metafield definition.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The namespace owned by the definition after the definition has been activated.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? @namespace { get; set; } = null;

    /// <summary>
    /// The list of resource types that the standard metafield definition can be applied to.
    /// </summary>
    [JsonPropertyName("ownerTypes")]
    public ICollection<MetafieldOwnerType>? ownerTypes { get; set; } = null;

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