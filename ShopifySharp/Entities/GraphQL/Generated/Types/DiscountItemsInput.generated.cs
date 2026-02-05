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
/// The input fields for the items attached to a discount. You can specify the discount items by product ID or collection ID.
/// </summary>
public record DiscountItemsInput : GraphQLInputObject<DiscountItemsInput>
{
    /// <summary>
    /// Whether all items should be selected for the discount. Not supported for Buy X get Y discounts.
    /// </summary>
    [JsonPropertyName("all")]
    public bool? all { get; set; } = null;

    /// <summary>
    /// The collections that are attached to a discount.
    /// </summary>
    [JsonPropertyName("collections")]
    public DiscountCollectionsInput? collections { get; set; } = null;

    /// <summary>
    /// The
    /// [products](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product) and
    /// [product variants](https://shopify.dev/docs/api/admin-graphql/latest/objects/productvariant)
    /// that the discount applies to.
    /// </summary>
    [JsonPropertyName("products")]
    public DiscountProductsInput? products { get; set; } = null;
}