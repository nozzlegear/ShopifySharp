#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The [constraints](https://shopify.dev/apps/build/custom-data/metafields/conditional-metafield-definitions)
/// that determine what subtypes of resources a metafield definition applies to.
/// </summary>
public record MetafieldDefinitionConstraints : IGraphQLObject
{
    /// <summary>
    /// The category of resource subtypes that the definition applies to.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The specific constraint subtype values that the definition applies to.
    /// </summary>
    [JsonPropertyName("values")]
    public MetafieldDefinitionConstraintValueConnection? values { get; set; } = null;
}