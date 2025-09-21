#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to update metafield definition [constraints](https://shopify.dev/apps/build/custom-data/metafields/conditional-metafield-definitions).
/// Each constraint applies a metafield definition to a subtype of a resource.
/// </summary>
public record MetafieldDefinitionConstraintsUpdatesInput : GraphQLInputObject<MetafieldDefinitionConstraintsUpdatesInput>
{
    /// <summary>
    /// The category of resource subtypes that the definition applies to.
    /// If omitted and the definition is already constrained, the existing constraint key will be used.
    /// If set to `null`, all constraints will be removed.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The specific constraint subtype values to create or delete.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<MetafieldDefinitionConstraintValueUpdateInput>? values { get; set; } = null;
}