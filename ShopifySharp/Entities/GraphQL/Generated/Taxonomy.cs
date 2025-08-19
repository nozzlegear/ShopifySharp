#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The Taxonomy resource lets you access the categories, attributes and values of a taxonomy tree.
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