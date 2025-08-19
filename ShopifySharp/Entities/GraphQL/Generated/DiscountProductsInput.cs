#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for adding and removing
/// [products](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product) and
/// [product variants](https://shopify.dev/docs/api/admin-graphql/latest/objects/productvariant)
/// as prerequisites or as eligible items for a discount.
/// </summary>
public record DiscountProductsInput : GraphQLInputObject<DiscountProductsInput>
{
    /// <summary>
    /// The IDs of the products to add as prerequisites or as eligible items for a discount.
    /// </summary>
    [JsonPropertyName("productsToAdd")]
    public ICollection<string>? productsToAdd { get; set; } = null;

    /// <summary>
    /// The IDs of the products to remove as prerequisites or as eligible items for a discount.
    /// </summary>
    [JsonPropertyName("productsToRemove")]
    public ICollection<string>? productsToRemove { get; set; } = null;

    /// <summary>
    /// The IDs of the product variants to add as prerequisites or as eligible items for a discount.
    /// </summary>
    [JsonPropertyName("productVariantsToAdd")]
    public ICollection<string>? productVariantsToAdd { get; set; } = null;

    /// <summary>
    /// The IDs of the product variants to remove as prerequisites or as eligible items for a discount.
    /// </summary>
    [JsonPropertyName("productVariantsToRemove")]
    public ICollection<string>? productVariantsToRemove { get; set; } = null;
}