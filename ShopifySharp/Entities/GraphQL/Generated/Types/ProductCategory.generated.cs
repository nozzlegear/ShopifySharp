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
/// The details of a specific product category within Shopify's [standardized product taxonomy](https://shopify.github.io/product-taxonomy/releases/unstable/?categoryId=sg-4-17-2-17).
/// Provides access to the associated [`ProductTaxonomyNode`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductTaxonomyNode).
/// </summary>
public record ProductCategory : IGraphQLObject
{
    /// <summary>
    /// The product taxonomy node associated with the product category.
    /// </summary>
    [JsonPropertyName("productTaxonomyNode")]
    public ProductTaxonomyNode? productTaxonomyNode { get; set; } = null;
}