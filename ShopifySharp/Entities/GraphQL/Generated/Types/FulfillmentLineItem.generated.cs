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
/// A line item from an
/// [`Order`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order)
/// that's included in a [`Fulfillment`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Fulfillment).
/// Links the fulfillment to specific items from the original order, tracking how
/// many units were fulfilled.
/// > Note: The discounted total excludes order-level discounts, showing only line-item specific discount amounts.
/// </summary>
public record FulfillmentLineItem : IGraphQLObject, INode
{
    /// <summary>
    /// The total price after discounts are applied.
    /// </summary>
    [JsonPropertyName("discountedTotal")]
    [Obsolete("Use `discountedTotalSet` instead.")]
    public decimal? discountedTotal { get; set; } = null;

    /// <summary>
    /// The total price after discounts are applied in shop and presentment
    /// currencies. This value doesn't include order-level discounts.
    /// </summary>
    [JsonPropertyName("discountedTotalSet")]
    public MoneyBag? discountedTotalSet { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The associated order's line item.
    /// </summary>
    [JsonPropertyName("lineItem")]
    public LineItem? lineItem { get; set; } = null;

    /// <summary>
    /// The total price before discounts are applied.
    /// </summary>
    [JsonPropertyName("originalTotal")]
    [Obsolete("Use `originalTotalSet` instead.")]
    public decimal? originalTotal { get; set; } = null;

    /// <summary>
    /// The total price before discounts are applied in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("originalTotalSet")]
    public MoneyBag? originalTotalSet { get; set; } = null;

    /// <summary>
    /// Number of line items in the fulfillment.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;
}