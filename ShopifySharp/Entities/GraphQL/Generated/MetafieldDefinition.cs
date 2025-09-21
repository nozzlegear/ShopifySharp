#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Metafield definitions enable you to define additional validation constraints for metafields, and enable the
/// merchant to edit metafield values in context.
/// </summary>
public record MetafieldDefinition : IGraphQLObject, INode
{
    /// <summary>
    /// The access settings associated with the metafield definition.
    /// </summary>
    [JsonPropertyName("access")]
    public MetafieldAccess? access { get; set; } = null;

    /// <summary>
    /// The capabilities of the metafield definition.
    /// </summary>
    [JsonPropertyName("capabilities")]
    public MetafieldCapabilities? capabilities { get; set; } = null;

    /// <summary>
    /// The [constraints](https://shopify.dev/apps/build/custom-data/metafields/conditional-metafield-definitions)
    /// that determine what subtypes of resources a metafield definition applies to.
    /// </summary>
    [JsonPropertyName("constraints")]
    public MetafieldDefinitionConstraints? constraints { get; set; } = null;

    /// <summary>
    /// The description of the metafield definition.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The unique identifier for the metafield definition within its namespace.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The metafields that belong to the metafield definition.
    /// </summary>
    [JsonPropertyName("metafields")]
    public MetafieldConnection? metafields { get; set; } = null;

    /// <summary>
    /// The count of the metafields that belong to the metafield definition.
    /// </summary>
    [JsonPropertyName("metafieldsCount")]
    public int? metafieldsCount { get; set; } = null;

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
    /// The position of the metafield definition in the pinned list.
    /// </summary>
    [JsonPropertyName("pinnedPosition")]
    public int? pinnedPosition { get; set; } = null;

    /// <summary>
    /// The standard metafield definition template associated with the metafield definition.
    /// </summary>
    [JsonPropertyName("standardTemplate")]
    public StandardMetafieldDefinitionTemplate? standardTemplate { get; set; } = null;

    /// <summary>
    /// The type of data that each of the metafields that belong to the metafield definition will store.
    /// Refer to the list of [supported types](https://shopify.dev/apps/metafields/types).
    /// </summary>
    [JsonPropertyName("type")]
    public MetafieldDefinitionType? type { get; set; } = null;

    /// <summary>
    /// Whether the metafield definition can be used as a collection condition.
    /// </summary>
    [JsonPropertyName("useAsCollectionCondition")]
    public bool? useAsCollectionCondition { get; set; } = null;

    /// <summary>
    /// A list of [validation options](https://shopify.dev/apps/metafields/definitions/validation) for
    /// the metafields that belong to the metafield definition. For example, for a metafield definition with the
    /// type `date`, you can set a minimum date validation so that each of the metafields that belong to it can only
    /// store dates after the specified minimum.
    /// </summary>
    [JsonPropertyName("validations")]
    public ICollection<MetafieldDefinitionValidation>? validations { get; set; } = null;

    /// <summary>
    /// The validation status for the metafields that belong to the metafield definition.
    /// </summary>
    [JsonPropertyName("validationStatus")]
    public MetafieldDefinitionValidationStatus? validationStatus { get; set; } = null;
}