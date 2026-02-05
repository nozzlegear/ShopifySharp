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
/// The input fields required to create metafield definition [constraints](https://shopify.dev/apps/build/custom-data/metafields/conditional-metafield-definitions).
/// Each constraint applies a metafield definition to a subtype of a resource.
/// </summary>
public record MetafieldDefinitionConstraintsInput : GraphQLInputObject<MetafieldDefinitionConstraintsInput>
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
    public ICollection<string>? values { get; set; } = null;
}