#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for creating or updating an automatic discount
/// that's managed by an app.
/// Use these input fields when you need advanced, custom, or
/// dynamic discount capabilities that aren't supported by
/// [Shopify's native discount types](https://help.shopify.com/manual/discounts/discount-types).
/// </summary>
public record DiscountAutomaticAppInput : GraphQLInputObject<DiscountAutomaticAppInput>
{
    /// <summary>
    /// Whether the discount applies on one-time purchases.
    /// </summary>
    [JsonPropertyName("appliesOnOneTimePurchase")]
    public bool? appliesOnOneTimePurchase { get; set; } = null;

    /// <summary>
    /// Whether the discount applies on subscription items.
    /// [Subscriptions](https://shopify.dev/docs/apps/launch/billing/subscription-billing/offer-subscription-discounts)
    /// enable customers to purchase products
    /// on a recurring basis.
    /// </summary>
    [JsonPropertyName("appliesOnSubscription")]
    public bool? appliesOnSubscription { get; set; } = null;

    /// <summary>
    /// The
    /// [discount classes](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations)
    /// that you can use in combination with
    /// [Shopify discount types](https://help.shopify.com/manual/discounts/discount-types).
    /// </summary>
    [JsonPropertyName("combinesWith")]
    public DiscountCombinesWithInput? combinesWith { get; set; } = null;

    /// <summary>
    /// Determines which discount effects the discount can apply.
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
    /// The
    /// [function ID](https://shopify.dev/docs/apps/build/functions/input-output/metafields-for-input-queries)
    /// associated with the app extension providing the
    /// [discount type](https://help.shopify.com/manual/discounts/discount-types).
    /// </summary>
    [JsonPropertyName("functionId")]
    public string? functionId { get; set; } = null;

    /// <summary>
    /// Additional metafields to associate to the discount.
    /// [Metafields](https://shopify.dev/docs/apps/build/custom-data)
    /// provide dynamic function configuration with
    /// different parameters, such as `percentage` for a percentage discount. Merchants can set metafield values
    /// in the Shopify admin, which makes the discount function more flexible and customizable.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<MetafieldInput>? metafields { get; set; } = null;

    /// <summary>
    /// The number of billing cycles for which the discount can be applied,
    /// which is useful for subscription-based discounts. For example, if you set this field
    /// to `3`, then the discount only applies to the first three billing cycles of a
    /// subscription. If you specify `0`, then the discount applies indefinitely.
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
}