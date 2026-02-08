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
/// The information for [line
/// items](https://shopify.dev/docs/api/admin-graphql/latest/objects/LineItem) that
/// are part of a bundle. When a bundle is purchased, each component line item references its [`LineItemGroup`](https://shopify.dev/docs/api/admin-graphql/latest/objects/LineItemGroup) through the [`lineItemGroup`](https://shopify.dev/docs/api/admin-graphql/latest/objects/LineItem#field-lineItemGroup)
/// field to maintain the relationship with the bundle.
/// The parent bundle's product, variant, and custom attributes enable apps to group
/// and display bundle components in order management systems, transactional emails,
/// and other contexts where understanding the bundle structure is needed.
/// Learn more about [product bundles](https://shopify.dev/docs/apps/build/product-merchandising/bundles).
/// </summary>
public record LineItemGroup : IGraphQLObject, INode
{
    /// <summary>
    /// A list of attributes that represent custom features or special requests.
    /// </summary>
    [JsonPropertyName("customAttributes")]
    public ICollection<Attribute>? customAttributes { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// ID of the product of the line item group.
    /// </summary>
    [JsonPropertyName("productId")]
    public string? productId { get; set; } = null;

    /// <summary>
    /// Quantity of the line item group on the order.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// Title of the line item group.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// ID of the variant of the line item group.
    /// </summary>
    [JsonPropertyName("variantId")]
    public string? variantId { get; set; } = null;

    /// <summary>
    /// SKU of the variant of the line item group.
    /// </summary>
    [JsonPropertyName("variantSku")]
    public string? variantSku { get; set; } = null;
}