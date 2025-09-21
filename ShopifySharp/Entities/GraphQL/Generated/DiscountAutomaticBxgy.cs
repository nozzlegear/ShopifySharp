#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The `DiscountAutomaticBxgy` object lets you manage
/// [buy X get Y discounts (BXGY)](https://help.shopify.com/manual/discounts/discount-types/buy-x-get-y)
/// that are automatically applied on a cart and at checkout. BXGY discounts incentivize customers by offering
/// them additional items at a discounted price or for free when they purchase a specified quantity of items.
/// The `DiscountAutomaticBxgy` object stores information about automatic BXGY discounts that apply to
/// specific [products and variants](https://shopify.dev/docs/api/admin-graphql/latest/objects/DiscountProducts),
/// [collections](https://shopify.dev/docs/api/admin-graphql/latest/objects/DiscountCollections),
/// or [all items in a cart](https://shopify.dev/docs/api/admin-graphql/latest/objects/AllDiscountItems).
/// Learn more about working with [Shopify's discount model](https://shopify.dev/docs/apps/build/discounts),
/// including limitations and considerations.
/// > Note:
/// > The [`DiscountCodeBxgy`](https://shopify.dev/docs/api/admin-graphql/latest/objects/DiscountCodeBxgy)
/// object has similar functionality to the `DiscountAutomaticBxgy` object, but customers need to enter a code to
/// receive a discount.
/// </summary>
public record DiscountAutomaticBxgy : IGraphQLUnionCase, IGraphQLObject, IHasEvents, INode
{
    /// <summary>
    /// The number of times that the discount has been used.
    /// For example, if a "Buy 3, Get 1 Free" t-shirt discount
    /// is automatically applied in 200 transactions, then the
    /// discount has been used 200 times.
    /// This value is updated asynchronously. As a result,
    /// it might be lower than the actual usage count until the
    /// asynchronous process is completed.
    /// </summary>
    [JsonPropertyName("asyncUsageCount")]
    public int? asyncUsageCount { get; set; } = null;

    /// <summary>
    /// The
    /// [discount classes](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations)
    /// that you can use in combination with
    /// [Shopify discount types](https://help.shopify.com/manual/discounts/discount-types).
    /// </summary>
    [JsonPropertyName("combinesWith")]
    public DiscountCombinesWith? combinesWith { get; set; } = null;

    /// <summary>
    /// The date and time when the discount was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The items eligible for the discount and the required quantity of each to receive the discount.
    /// </summary>
    [JsonPropertyName("customerBuys")]
    public DiscountCustomerBuys? customerBuys { get; set; } = null;

    /// <summary>
    /// The items in the order that qualify for the discount, their quantities, and the total value of the discount.
    /// </summary>
    [JsonPropertyName("customerGets")]
    public DiscountCustomerGets? customerGets { get; set; } = null;

    /// <summary>
    /// The [discount class](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations)
    /// that's used to control how discounts can be combined.
    /// </summary>
    [JsonPropertyName("discountClass")]
    [Obsolete("Use `discountClasses` instead.")]
    public MerchandiseDiscountClass? discountClass { get; set; } = null;

    /// <summary>
    /// The classes of the discount.
    /// </summary>
    [JsonPropertyName("discountClasses")]
    public ICollection<DiscountClass>? discountClasses { get; set; } = null;

    /// <summary>
    /// The date and time when the discount expires and is no longer available to customers.
    /// For discounts without a fixed expiration date, specify `null`.
    /// </summary>
    [JsonPropertyName("endsAt")]
    public DateTime? endsAt { get; set; } = null;

    /// <summary>
    /// The paginated list of events associated with the host subject.
    /// </summary>
    [JsonPropertyName("events")]
    public EventConnection? events { get; set; } = null;

    /// <summary>
    /// A legacy unique ID for the discount.
    /// </summary>
    [JsonPropertyName("id")]
    [Obsolete("Use DiscountAutomaticNode.id instead.")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The date and time when the discount becomes active and is available to customers.
    /// </summary>
    [JsonPropertyName("startsAt")]
    public DateTime? startsAt { get; set; } = null;

    /// <summary>
    /// The status of the discount that describes its availability,
    /// expiration, or pending activation.
    /// </summary>
    [JsonPropertyName("status")]
    public DiscountStatus? status { get; set; } = null;

    /// <summary>
    /// A detailed explanation of what the discount is,
    /// who can use it, when and where it applies, and any associated
    /// rules or limitations.
    /// </summary>
    [JsonPropertyName("summary")]
    public string? summary { get; set; } = null;

    /// <summary>
    /// The discount's name that displays to merchants in the Shopify admin and to customers.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The date and time when the discount was updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? updatedAt { get; set; } = null;

    /// <summary>
    /// The number of times that the discount has been used.
    /// </summary>
    [JsonPropertyName("usageCount")]
    [Obsolete("Use `asyncUsageCount` instead.")]
    public int? usageCount { get; set; } = null;

    /// <summary>
    /// The maximum number of times that the discount can be applied to an order.
    /// </summary>
    [JsonPropertyName("usesPerOrderLimit")]
    public int? usesPerOrderLimit { get; set; } = null;
}