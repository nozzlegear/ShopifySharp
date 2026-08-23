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
/// A non-metaobject metafield definition usable as a collection condition.
/// </summary>
public record CollectionConditionBasicMetafieldDefinition : IGraphQLObject, ICollectionConditionMetafieldDefinitionInterface
{
    /// <summary>
    /// The description of the metafield definition.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The ID of the underlying metafield definition.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The unique identifier for the metafield definition within its namespace.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The human-readable name of the metafield definition.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The container for a group of metafields that the metafield definition is associated with.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? @namespace { get; set; } = null;

    /// <summary>
    /// The resource type that the metafield definition is attached to.
    /// </summary>
    [JsonPropertyName("ownerType")]
    public MetafieldOwnerType? ownerType { get; set; } = null;

    /// <summary>
    /// The data type of the metafield definition.
    /// </summary>
    [JsonPropertyName("type")]
    public MetafieldDefinitionType? type { get; set; } = null;

    /// <summary>
    /// A list of validation options for the metafields that belong to the metafield definition.
    /// </summary>
    [JsonPropertyName("validations")]
    public ICollection<MetafieldDefinitionValidation>? validations { get; set; } = null;
}