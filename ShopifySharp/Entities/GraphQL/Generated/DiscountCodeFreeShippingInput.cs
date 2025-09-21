#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for creating or updating a [free shipping discount](https://help.shopify.com/manual/discounts/discount-types/free-shipping)
/// that's applied on a cart and at checkout when a customer enters a code.
/// </summary>
public record DiscountCodeFreeShippingInput : GraphQLInputObject<DiscountCodeFreeShippingInput>
{
    /// <summary>
    /// Whether a customer can only use the discount once.
    /// </summary>
    [JsonPropertyName("appliesOncePerCustomer")]
    public bool? appliesOncePerCustomer { get; set; } = null;

    /// <summary>
    /// Whether the discount applies on one-time purchases. A one-time purchase is a
    /// transaction where you pay a single time for a product, without any ongoing
    /// commitments or recurring charges.
    /// </summary>
    [JsonPropertyName("appliesOnOneTimePurchase")]
    public bool? appliesOnOneTimePurchase { get; set; } = null;

    /// <summary>
    /// Whether the discount applies on subscription items. [Subscriptions](https://shopify.dev/docs/apps/launch/billing/subscription-billing/offer-subscription-discounts)
    /// enable customers to purchase products on a recurring basis.
    /// </summary>
    [JsonPropertyName("appliesOnSubscription")]
    public bool? appliesOnSubscription { get; set; } = null;

    /// <summary>
    /// The code that customers use to apply the discount.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// The
    /// [discount classes](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations)
    /// that you can use in combination with the shipping discount.
    /// </summary>
    [JsonPropertyName("combinesWith")]
    public DiscountCombinesWithInput? combinesWith { get; set; } = null;

    /// <summary>
    /// The shipping destinations where the free shipping discount can be applied. You
    /// can specify whether the discount applies to all countries, or specify
    /// individual countries.
    /// </summary>
    [JsonPropertyName("destination")]
    public DiscountShippingDestinationSelectionInput? destination { get; set; } = null;

    /// <summary>
    /// The date and time when the discount expires and is no longer available to customers.
    /// For discounts without a fixed expiration date, specify `null`.
    /// </summary>
    [JsonPropertyName("endsAt")]
    public DateTime? endsAt { get; set; } = null;

    /// <summary>
    /// The maximum shipping price, in the shop's currency, that qualifies for free shipping.
    /// <br/><br/>
    /// For example, if set to 20.00, then only shipping rates that cost $20.00 or
    /// less will be made free. To apply the discount to all shipping rates, specify `null`.
    /// </summary>
    [JsonPropertyName("maximumShippingPrice")]
    public decimal? maximumShippingPrice { get; set; } = null;

    /// <summary>
    /// The minimum subtotal or quantity of items that are required for the discount to be applied.
    /// </summary>
    [JsonPropertyName("minimumRequirement")]
    public DiscountMinimumRequirementInput? minimumRequirement { get; set; } = null;

    /// <summary>
    /// The number of billing cycles for which the discount can be applied, which is useful for subscription-based discounts.
    /// <br/><br/>
    /// For example, if set to `3`, then the discount only applies to the first three
    /// billing cycles of a subscription. If set to `0`, then the discount applies indefinitely.
    /// </summary>
    [JsonPropertyName("recurringCycleLimit")]
    public int? recurringCycleLimit { get; set; } = null;

    /// <summary>
    /// The date and time when the discount becomes active and is available to customers.
    /// </summary>
    [JsonPropertyName("startsAt")]
    public DateTime? startsAt { get; set; } = null;

    /// <summary>
    /// The discount's name that displays to merchants in the Shopify admin and to customers.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The maximum number of times that a customer can use the discount.
    /// For discounts with unlimited usage, specify `null`.
    /// </summary>
    [JsonPropertyName("usageLimit")]
    public int? usageLimit { get; set; } = null;
}