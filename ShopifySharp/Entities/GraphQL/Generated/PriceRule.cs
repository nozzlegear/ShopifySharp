#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Price rules are a set of conditions, including entitlements and prerequisites,
/// that must be met in order for a discount code to apply.
/// We recommend using the types and queries detailed at [Getting started with discounts](https://shopify.dev/docs/apps/selling-strategies/discounts/getting-started)
/// instead. These will replace the GraphQL `PriceRule` object and REST Admin
/// `PriceRule` and `DiscountCode` resources.
/// </summary>
public record PriceRule : IGraphQLObject, ICommentEventSubject, IHasEvents, ILegacyInteroperability, INode
{
    /// <summary>
    /// The maximum number of times that the price rule can be allocated onto an order.
    /// </summary>
    [JsonPropertyName("allocationLimit")]
    public int? allocationLimit { get; set; } = null;

    /// <summary>
    /// The method by which the price rule's value is allocated to its entitled items.
    /// </summary>
    [JsonPropertyName("allocationMethod")]
    public PriceRuleAllocationMethod? allocationMethod { get; set; } = null;

    /// <summary>
    /// The application that created the price rule.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// The
    /// [discount classes](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations)
    /// that you can use in combination with
    /// [Shopify discount types](https://help.shopify.com/manual/discounts/discount-types).
    /// </summary>
    [JsonPropertyName("combinesWith")]
    public DiscountCombinesWith? combinesWith { get; set; } = null;

    /// <summary>
    /// The date and time when the price rule was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The customers that can use this price rule.
    /// </summary>
    [JsonPropertyName("customerSelection")]
    public PriceRuleCustomerSelection? customerSelection { get; set; } = null;

    /// <summary>
    /// The
    /// [discount class](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations)
    /// that's used to control how discounts can be combined.
    /// </summary>
    [JsonPropertyName("discountClass")]
    [Obsolete("Use `discountClasses` instead.")]
    public DiscountClass? discountClass { get; set; } = null;

    /// <summary>
    /// The classes of the discount.
    /// </summary>
    [JsonPropertyName("discountClasses")]
    public ICollection<DiscountClass>? discountClasses { get; set; } = null;

    /// <summary>
    /// List of the price rule's discount codes.
    /// </summary>
    [JsonPropertyName("discountCodes")]
    public PriceRuleDiscountCodeConnection? discountCodes { get; set; } = null;

    /// <summary>
    /// How many discount codes associated with the price rule.
    /// </summary>
    [JsonPropertyName("discountCodesCount")]
    public Count? discountCodesCount { get; set; } = null;

    /// <summary>
    /// The date and time when the price rule ends. For open-ended price rules, use `null`.
    /// </summary>
    [JsonPropertyName("endsAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? endsAt { get; set; } = null;

    /// <summary>
    /// Quantity of prerequisite items required for the price rule to be applicable,  compared to quantity of entitled items.
    /// </summary>
    [JsonPropertyName("entitlementToPrerequisiteQuantityRatio")]
    [Obsolete("Use `prerequisiteToEntitlementQuantityRatio` instead.")]
    public PriceRuleEntitlementToPrerequisiteQuantityRatio? entitlementToPrerequisiteQuantityRatio { get; set; } = null;

    /// <summary>
    /// The paginated list of events associated with the price rule.
    /// </summary>
    [JsonPropertyName("events")]
    public EventConnection? events { get; set; } = null;

    /// <summary>
    /// A list of the price rule's features.
    /// </summary>
    [JsonPropertyName("features")]
    public ICollection<PriceRuleFeature>? features { get; set; } = null;

    /// <summary>
    /// Indicates whether there are any timeline comments on the price rule.
    /// </summary>
    [JsonPropertyName("hasTimelineComment")]
    public bool? hasTimelineComment { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The items to which the price rule applies.
    /// </summary>
    [JsonPropertyName("itemEntitlements")]
    public PriceRuleItemEntitlements? itemEntitlements { get; set; } = null;

    /// <summary>
    /// The items required for the price rule to be applicable.
    /// </summary>
    [JsonPropertyName("itemPrerequisites")]
    public PriceRuleLineItemPrerequisites? itemPrerequisites { get; set; } = null;

    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; } = null;

    /// <summary>
    /// Whether the price rule can be applied only once per customer.
    /// </summary>
    [JsonPropertyName("oncePerCustomer")]
    public bool? oncePerCustomer { get; set; } = null;

    /// <summary>
    /// The number of the entitled items must fall within this range for the price rule to be applicable.
    /// </summary>
    [JsonPropertyName("prerequisiteQuantityRange")]
    public PriceRuleQuantityRange? prerequisiteQuantityRange { get; set; } = null;

    /// <summary>
    /// The shipping cost must fall within this range for the price rule to be applicable.
    /// </summary>
    [JsonPropertyName("prerequisiteShippingPriceRange")]
    public PriceRuleMoneyRange? prerequisiteShippingPriceRange { get; set; } = null;

    /// <summary>
    /// The sum of the entitled items subtotal prices must fall within this range for the price rule to be applicable.
    /// </summary>
    [JsonPropertyName("prerequisiteSubtotalRange")]
    public PriceRuleMoneyRange? prerequisiteSubtotalRange { get; set; } = null;

    /// <summary>
    /// Quantity of prerequisite items required for the price rule to be applicable,  compared to quantity of entitled items.
    /// </summary>
    [JsonPropertyName("prerequisiteToEntitlementQuantityRatio")]
    public PriceRulePrerequisiteToEntitlementQuantityRatio? prerequisiteToEntitlementQuantityRatio { get; set; } = null;

    /// <summary>
    /// URLs that can be used to share the discount.
    /// </summary>
    [JsonPropertyName("shareableUrls")]
    public ICollection<PriceRuleShareableUrl>? shareableUrls { get; set; } = null;

    /// <summary>
    /// The shipping lines to which the price rule applies.
    /// </summary>
    [JsonPropertyName("shippingEntitlements")]
    public PriceRuleShippingLineEntitlements? shippingEntitlements { get; set; } = null;

    /// <summary>
    /// The date and time when the price rule starts.
    /// </summary>
    [JsonPropertyName("startsAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? startsAt { get; set; } = null;

    /// <summary>
    /// The status of the price rule.
    /// </summary>
    [JsonPropertyName("status")]
    public PriceRuleStatus? status { get; set; } = null;

    /// <summary>
    /// A detailed summary of the price rule.
    /// </summary>
    [JsonPropertyName("summary")]
    public string? summary { get; set; } = null;

    /// <summary>
    /// The type of lines (line_item or shipping_line) to which the price rule applies.
    /// </summary>
    [JsonPropertyName("target")]
    public PriceRuleTarget? target { get; set; } = null;

    /// <summary>
    /// The title of the price rule.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The total sales from orders where the price rule was used.
    /// </summary>
    [JsonPropertyName("totalSales")]
    public MoneyV2? totalSales { get; set; } = null;

    /// <summary>
    /// A list of the price rule's features.
    /// </summary>
    [JsonPropertyName("traits")]
    [Obsolete("Use `features` instead.")]
    public ICollection<PriceRuleTrait>? traits { get; set; } = null;

    /// <summary>
    /// The number of times that the price rule has been used. This value is updated
    /// asynchronously and can be different than the actual usage count.
    /// </summary>
    [JsonPropertyName("usageCount")]
    public int? usageCount { get; set; } = null;

    /// <summary>
    /// The maximum number of times that the price rule can be used in total.
    /// </summary>
    [JsonPropertyName("usageLimit")]
    public int? usageLimit { get; set; } = null;

    /// <summary>
    /// A time period during which a price rule is applicable.
    /// </summary>
    [JsonPropertyName("validityPeriod")]
    public PriceRuleValidityPeriod? validityPeriod { get; set; } = null;

    /// <summary>
    /// The value of the price rule.
    /// </summary>
    [JsonPropertyName("value")]
    [Obsolete("Use `valueV2` instead.")]
    public PriceRuleValue? @value { get; set; } = null;

    /// <summary>
    /// The value of the price rule.
    /// </summary>
    [JsonPropertyName("valueV2")]
    public PricingValue? valueV2 { get; set; } = null;
}