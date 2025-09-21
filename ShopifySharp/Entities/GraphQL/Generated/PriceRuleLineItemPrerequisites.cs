#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Single or multiple line item products, product variants or collections required
/// for the price rule to be applicable, can also be provided in combination.
/// </summary>
public record PriceRuleLineItemPrerequisites : IGraphQLObject
{
    /// <summary>
    /// The collections required for the price rule to be applicable.
    /// </summary>
    [JsonPropertyName("collections")]
    public CollectionConnection? collections { get; set; } = null;

    /// <summary>
    /// The products required for the price rule to be applicable.
    /// </summary>
    [JsonPropertyName("products")]
    public ProductConnection? products { get; set; } = null;

    /// <summary>
    /// The product variants required for the price rule to be applicable.
    /// </summary>
    [JsonPropertyName("productVariants")]
    public ProductVariantConnection? productVariants { get; set; } = null;
}