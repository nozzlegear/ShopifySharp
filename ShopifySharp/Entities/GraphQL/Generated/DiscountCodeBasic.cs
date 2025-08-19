#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The `DiscountCodeBasic` object lets you manage
/// [amount off discounts](https://help.shopify.com/manual/discounts/discount-types/percentage-fixed-amount)
/// that are applied on a cart and at checkout when a customer enters a code. Amount off discounts give customers a
/// fixed value or a percentage off the products in an order, but don't apply to shipping costs.
/// The `DiscountCodeBasic` object stores information about amount off code discounts that apply to
/// specific [products and variants](https://shopify.dev/docs/api/admin-graphql/latest/objects/DiscountProducts),
/// [collections](https://shopify.dev/docs/api/admin-graphql/latest/objects/DiscountCollections),
/// or [all items in a cart](https://shopify.dev/docs/api/admin-graphql/latest/objects/AllDiscountItems).
/// Learn more about working with [Shopify's discount model](https://shopify.dev/docs/apps/build/discounts),
/// including limitations and considerations.
/// > Note:
/// > The [`DiscountAutomaticBasic`](https://shopify.dev/docs/api/admin-graphql/latest/objects/DiscountAutomaticBasic)
/// object has similar functionality to the `DiscountCodeBasic` object, but discounts are automatically applied,
/// without the need for customers to enter a code.
/// </summary>
public record DiscountCodeBasic : Discount, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// Whether a customer can only use the discount once.
    /// </summary>
    [JsonPropertyName("appliesOncePerCustomer")]
    public bool? appliesOncePerCustomer { get; set; } = null;

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
    /// A list codes that customers can use to redeem the discount.
    /// </summary>
    [JsonPropertyName("codes")]
    public DiscountRedeemCodeConnection? codes { get; set; } = null;

    /// <summary>
    /// The number of codes that a customer can use to redeem the discount.
    /// </summary>
    [JsonPropertyName("codesCount")]
    public Count? codesCount { get; set; } = null;

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
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The items in the order that qualify for the discount, their quantities, and the total value of the discount.
    /// </summary>
    [JsonPropertyName("customerGets")]
    public DiscountCustomerGets? customerGets { get; set; } = null;

    /// <summary>
    /// The customers that can use the discount.
    /// </summary>
    [JsonPropertyName("customerSelection")]
    [Obsolete("Use `context` instead.")]
    public DiscountCustomerSelection? customerSelection { get; set; } = null;

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
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? endsAt { get; set; } = null;

    /// <summary>
    /// Whether there are
    /// [timeline comments](https://help.shopify.com/manual/discounts/managing-discount-codes#use-the-discount-timeline)
    /// associated with the discount.
    /// </summary>
    [JsonPropertyName("hasTimelineComment")]
    public bool? hasTimelineComment { get; set; } = null;

    /// <summary>
    /// The minimum subtotal or quantity of items that are required for the discount to be applied.
    /// </summary>
    [JsonPropertyName("minimumRequirement")]
    public DiscountMinimumRequirement? minimumRequirement { get; set; } = null;

    /// <summary>
    /// The number of billing cycles for which the discount can be applied,
    /// which is useful for subscription-based discounts. For example, if you set this field
    /// to `3`, then the discount only applies to the first three billing cycles of a
    /// subscription. If you specify `0`, then the discount applies indefinitely.
    /// </summary>
    [JsonPropertyName("recurringCycleLimit")]
    public int? recurringCycleLimit { get; set; } = null;

    /// <summary>
    /// A list of URLs that the app can use to share the discount.
    /// </summary>
    [JsonPropertyName("shareableUrls")]
    public ICollection<DiscountShareableUrl>? shareableUrls { get; set; } = null;

    /// <summary>
    /// An abbreviated version of the discount
    /// [`summary`](https://shopify.dev/docs/api/admin-graphql/latest/objects/DiscountCodeBasic#field-summary)
    /// field.
    /// </summary>
    [JsonPropertyName("shortSummary")]
    public string? shortSummary { get; set; } = null;

    /// <summary>
    /// The date and time when the discount becomes active and is available to customers.
    /// </summary>
    [JsonPropertyName("startsAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
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
    /// The total sales from orders where the discount was used.
    /// </summary>
    [JsonPropertyName("totalSales")]
    public MoneyV2? totalSales { get; set; } = null;

    /// <summary>
    /// The date and time when the discount was updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? updatedAt { get; set; } = null;

    /// <summary>
    /// The maximum number of times that a customer can use the discount.
    /// For discounts with unlimited usage, specify `null`.
    /// </summary>
    [JsonPropertyName("usageLimit")]
    public int? usageLimit { get; set; } = null;
}