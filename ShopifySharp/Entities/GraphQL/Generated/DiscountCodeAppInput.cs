#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for creating or updating a code discount, where the discount
/// type is provided by an app extension that uses [Shopify
/// Functions](https://shopify.dev/docs/apps/build/functions).
/// Use these input fields when you need advanced or custom discount capabilities
/// that aren't supported by [Shopify's native discount
/// types](https://help.shopify.com/manual/discounts/discount-types).
/// </summary>
public record DiscountCodeAppInput : GraphQLInputObject<DiscountCodeAppInput>
{
    /// <summary>
    /// Whether a customer can only use the discount once.
    /// </summary>
    [JsonPropertyName("appliesOncePerCustomer")]
    public bool? appliesOncePerCustomer { get; set; } = null;

    /// <summary>
    /// Whether the discount applies on regular one-time-purchase items.
    /// </summary>
    [JsonPropertyName("appliesOnOneTimePurchase")]
    public bool? appliesOnOneTimePurchase { get; set; } = null;

    /// <summary>
    /// Whether the discount applies to subscriptions items.
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
    /// The [function ID](https://shopify.dev/docs/apps/build/functions/input-output/metafields-for-input-queries) associated with the app extension that's providing the [discount
    /// type](https://help.shopify.com/manual/discounts/discount-types).
    /// </summary>
    [JsonPropertyName("functionId")]
    public string? functionId { get; set; } = null;

    /// <summary>
    /// Additional metafields to associate to the discount.
    /// [Metafields](https://shopify.dev/docs/apps/build/custom-data) provide dynamic
    /// function configuration with different parameters, such as `percentage` for a
    /// percentage discount. Merchants can set metafield values in the Shopify admin,
    /// which makes the discount function more flexible and customizable.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<MetafieldInput>? metafields { get; set; } = null;

    /// <summary>
    /// The number of times a discount applies on recurring purchases (subscriptions).
    ///         0 will apply infinitely whereas 1 will only apply to the first checkout.
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