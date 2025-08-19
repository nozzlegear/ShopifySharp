#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The details of a specific product category within the [Shopify product taxonomy](https://shopify.github.io/product-taxonomy/releases/unstable/?categoryId=sg-4-17-2-17).
/// </summary>
public record ProductCategory : IGraphQLObject
{
    /// <summary>
    /// The product taxonomy node associated with the product category.
    /// </summary>
    [JsonPropertyName("productTaxonomyNode")]
    public ProductTaxonomyNode? productTaxonomyNode { get; set; } = null;
}