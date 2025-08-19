#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the details of a specific type of product within the [Shopify product taxonomy](https://shopify.github.io/product-taxonomy/releases/unstable/?categoryId=sg-4-17-2-17).
/// </summary>
public record StandardizedProductType : IGraphQLObject
{
    /// <summary>
    /// The product taxonomy node associated with the standardized product type.
    /// </summary>
    [JsonPropertyName("productTaxonomyNode")]
    public ProductTaxonomyNode? productTaxonomyNode { get; set; } = null;
}