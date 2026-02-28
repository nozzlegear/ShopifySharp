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
/// Represents Shopify's [standardized product taxonomy](https://shopify.github.io/product-taxonomy/releases/unstable/?categoryId=sg-4-17-2-17)
/// tree. Provides categories that you can filter by search criteria or hierarchical relationships.
/// You can search categories globally, retrieve children of a specific category,
/// find siblings, or get descendants. When you specify no filter arguments, you get
/// all top-level categories in the taxonomy.
/// </summary>
public record Taxonomy : IGraphQLObject
{
    /// <summary>
    /// Returns the categories of the product taxonomy based on the arguments provided.
    /// If a `search` argument is provided, then all categories that match the search query globally are returned.
    /// If a `children_of` argument is provided, then all children of the specified category are returned.
    /// If a `siblings_of` argument is provided, then all siblings of the specified category are returned.
    /// If a `decendents_of` argument is provided, then all descendents of the specified category are returned.
    /// If no arguments are provided, then all the top-level categories of the taxonomy are returned.
    /// </summary>
    [JsonPropertyName("categories")]
    public TaxonomyCategoryConnection? categories { get; set; } = null;
}