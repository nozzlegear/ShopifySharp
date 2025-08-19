#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a [Shopify product taxonomy](https://shopify.github.io/product-taxonomy/releases/unstable/?categoryId=sg-4-17-2-17) node.
/// </summary>
public record ProductTaxonomyNode : IGraphQLObject, INode
{
    /// <summary>
    /// The full name of the product taxonomy node. For example,  Animals & Pet Supplies > Pet Supplies > Dog Supplies > Dog Beds.
    /// </summary>
    [JsonPropertyName("fullName")]
    public string? fullName { get; set; } = null;

    /// <summary>
    /// The ID of the product taxonomy node.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether the node is a leaf node.
    /// </summary>
    [JsonPropertyName("isLeaf")]
    public bool? isLeaf { get; set; } = null;

    /// <summary>
    /// Whether the node is a root node.
    /// </summary>
    [JsonPropertyName("isRoot")]
    public bool? isRoot { get; set; } = null;

    /// <summary>
    /// The name of the product taxonomy node. For example, Dog Beds.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}