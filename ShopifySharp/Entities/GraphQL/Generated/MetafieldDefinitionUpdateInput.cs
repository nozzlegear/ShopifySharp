#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields required to update a metafield definition.
/// </summary>
public record MetafieldDefinitionUpdateInput : GraphQLInputObject<MetafieldDefinitionUpdateInput>
{
    /// <summary>
    /// The access settings that apply to each of the metafields that belong to the metafield definition.
    /// </summary>
    [JsonPropertyName("access")]
    public MetafieldAccessUpdateInput? access { get; set; } = null;

    /// <summary>
    /// The capabilities of the metafield definition.
    /// </summary>
    [JsonPropertyName("capabilities")]
    public MetafieldCapabilityUpdateInput? capabilities { get; set; } = null;

    /// <summary>
    /// The [constraints](https://shopify.dev/apps/build/custom-data/metafields/conditional-metafield-definitions)
    /// that determine what resources a metafield definition applies to.
    /// </summary>
    [JsonPropertyName("constraintsUpdates")]
    public MetafieldDefinitionConstraintsUpdatesInput? constraintsUpdates { get; set; } = null;

    /// <summary>
    /// The description for the metafield definition.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The unique identifier for the metafield definition within its namespace. Used to help identify the metafield
    /// definition, but can't be updated itself.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The human-readable name for the metafield definition.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The container for a group of metafields that the metafield definition is associated with. Used to help identify
    /// the metafield definition, but cannot be updated itself. If omitted, the app-reserved namespace will be used.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? @namespace { get; set; } = null;

    /// <summary>
    /// The resource type that the metafield definition is attached to. Used to help identify the metafield definition,
    /// but can't be updated itself.
    /// </summary>
    [JsonPropertyName("ownerType")]
    public MetafieldOwnerType? ownerType { get; set; } = null;

    /// <summary>
    /// Whether to pin the metafield definition.
    /// </summary>
    [JsonPropertyName("pin")]
    public bool? pin { get; set; } = null;

    /// <summary>
    /// A list of [validation options](https://shopify.dev/apps/metafields/definitions/validation) for
    /// the metafields that belong to the metafield definition. For example, for a metafield definition with the
    /// type `date`, you can set a minimum date validation so that each of the metafields that belong to it can only
    /// store dates after the specified minimum.
    /// </summary>
    [JsonPropertyName("validations")]
    public ICollection<MetafieldDefinitionValidationInput>? validations { get; set; } = null;
}