#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for creating or updating a
/// [buy X get Y discount (BXGY)](https://help.shopify.com/manual/discounts/discount-types/buy-x-get-y)
/// that's applied on a cart and at checkout when a customer enters a code.
/// </summary>
public record DiscountCodeBxgyInput : GraphQLInputObject<DiscountCodeBxgyInput>
{
    /// <summary>
    /// Whether a customer can only use the discount once.
    /// </summary>
    [JsonPropertyName("appliesOncePerCustomer")]
    public bool? appliesOncePerCustomer { get; set; } = null;

    /// <summary>
    /// The code that customers use to apply the discount.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// The
    /// [discount class](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations)
    /// that you can use in combination with
    /// [Shopify discount types](https://help.shopify.com/manual/discounts/discount-types).
    /// </summary>
    [JsonPropertyName("combinesWith")]
    public DiscountCombinesWithInput? combinesWith { get; set; } = null;

    /// <summary>
    /// The items eligible for the discount and the required quantity of each to receive the discount.
    /// </summary>
    [JsonPropertyName("customerBuys")]
    public DiscountCustomerBuysInput? customerBuys { get; set; } = null;

    /// <summary>
    /// The items in the order that qualify for the discount, their quantities, and the total value of the discount.
    /// </summary>
    [JsonPropertyName("customerGets")]
    public DiscountCustomerGetsInput? customerGets { get; set; } = null;

    /// <summary>
    /// The date and time when the discount expires and is no longer available to customers.
    /// For discounts without a fixed expiration date, specify `null`.
    /// </summary>
    [JsonPropertyName("endsAt")]
    public DateTime? endsAt { get; set; } = null;

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

    /// <summary>
    /// The maximum number of times that the discount can be applied to an order.
    /// </summary>
    [JsonPropertyName("usesPerOrderLimit")]
    public int? usesPerOrderLimit { get; set; } = null;
}