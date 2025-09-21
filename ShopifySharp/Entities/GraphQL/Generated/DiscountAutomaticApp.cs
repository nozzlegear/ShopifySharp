#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The `DiscountAutomaticApp` object stores information about automatic discounts
/// that are managed by an app using
/// [Shopify Functions](https://shopify.dev/docs/apps/build/functions).
/// Use `DiscountAutomaticApp`when you need advanced, custom, or
/// dynamic discount capabilities that aren't supported by
/// [Shopify's native discount types](https://help.shopify.com/manual/discounts/discount-types).
/// Learn more about creating
/// [custom discount functionality](https://shopify.dev/docs/apps/build/discounts/build-discount-function).
/// > Note:
/// > The [`DiscountCodeApp`](https://shopify.dev/docs/api/admin-graphql/latest/objects/DiscountCodeApp)
/// object has similar functionality to the `DiscountAutomaticApp` object, with the exception that `DiscountCodeApp`
/// stores information about discount codes that are managed by an app using Shopify Functions.
/// </summary>
public record DiscountAutomaticApp : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The details about the app extension that's providing the
    /// [discount type](https://help.shopify.com/manual/discounts/discount-types).
    /// This information includes the app extension's name and
    /// [client ID](https://shopify.dev/docs/apps/build/authentication-authorization/client-secrets),
    /// [App Bridge configuration](https://shopify.dev/docs/api/app-bridge),
    /// [discount class](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations),
    /// [function ID](https://shopify.dev/docs/apps/build/functions/input-output/metafields-for-input-queries),
    /// and other metadata about the discount type, including the discount type's name and description.
    /// </summary>
    [JsonPropertyName("appDiscountType")]
    public AppDiscountType? appDiscountType { get; set; } = null;

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
    /// The [globally-unique ID](https://shopify.dev/docs/api/usage/gids)
    /// for the discount.
    /// </summary>
    [JsonPropertyName("discountId")]
    public string? discountId { get; set; } = null;

    /// <summary>
    /// The date and time when the discount expires and is no longer available to customers.
    /// For discounts without a fixed expiration date, specify `null`.
    /// </summary>
    [JsonPropertyName("endsAt")]
    public DateTime? endsAt { get; set; } = null;

    /// <summary>
    /// The [error history](https://shopify.dev/docs/apps/build/functions/monitoring-and-errors)
    /// for the latest version of the discount type that the app provides.
    /// </summary>
    [JsonPropertyName("errorHistory")]
    public FunctionsErrorHistory? errorHistory { get; set; } = null;

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
    /// The status of the discount that describes its availability,
    /// expiration, or pending activation.
    /// </summary>
    [JsonPropertyName("status")]
    public DiscountStatus? status { get; set; } = null;

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
}