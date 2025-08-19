#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The details of a specific product category within the [Shopify product taxonomy](https://shopify.github.io/product-taxonomy/releases/unstable/?categoryId=sg-4-17-2-17).
/// </summary>
public record TaxonomyCategory : IGraphQLObject, INode
{
    /// <summary>
    /// The IDs of the category's ancestor categories.
    /// </summary>
    [JsonPropertyName("ancestorIds")]
    public ICollection<string>? ancestorIds { get; set; } = null;

    /// <summary>
    /// The attributes of the taxonomy category.
    /// </summary>
    [JsonPropertyName("attributes")]
    public TaxonomyCategoryAttributeConnection? attributes { get; set; } = null;

    /// <summary>
    /// The IDs of the category's child categories.
    /// </summary>
    [JsonPropertyName("childrenIds")]
    public ICollection<string>? childrenIds { get; set; } = null;

    /// <summary>
    /// The full name of the taxonomy category. For example, Animals & Pet Supplies > Pet Supplies > Dog Supplies > Dog Beds.
    /// </summary>
    [JsonPropertyName("fullName")]
    public string? fullName { get; set; } = null;

    /// <summary>
    /// The globally-unique ID of the TaxonomyCategory.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether the category is archived. The default value is `false`.
    /// </summary>
    [JsonPropertyName("isArchived")]
    public bool? isArchived { get; set; } = null;

    /// <summary>
    /// Whether the category is a leaf category. A leaf category doesn't have any
    /// subcategories beneath it. For example, in Animals & Pet Supplies > Pet
    /// Supplies > Dog Supplies > Dog Treadmills, Dog Treadmills is a leaf category.
    /// The value is `true` when there are no `childrenIds` specified.
    /// </summary>
    [JsonPropertyName("isLeaf")]
    public bool? isLeaf { get; set; } = null;

    /// <summary>
    /// Whether the category is a root category. A root category is at the top level
    /// of the category hierarchy and doesn't have a parent category. For example,
    /// Animals & Pet Supplies. The value is `true` when there's no `parentId` specified.
    /// </summary>
    [JsonPropertyName("isRoot")]
    public bool? isRoot { get; set; } = null;

    /// <summary>
    /// The level of the category in the taxonomy tree. Levels indicate the depth of
    /// the category from the root. For example, in Animals & Pet Supplies > Pet
    /// Supplies > Dog Supplies, Animals & Pet Supplies is at level 1, Animals & Pet
    /// Supplies > Pet Supplies is at level 2, and Animals & Pet Supplies > Pet
    /// Supplies > Dog Supplies is at level 3.
    /// </summary>
    [JsonPropertyName("level")]
    public int? level { get; set; } = null;

    /// <summary>
    /// The name of the taxonomy category. For example, Dog Beds.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The ID of the category's parent category.
    /// </summary>
    [JsonPropertyName("parentId")]
    public string? parentId { get; set; } = null;
}