#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The items in the order that qualify for the discount, their quantities, and the total value of the discount.
/// </summary>
public record DiscountCustomerGets : IGraphQLObject
{
    /// <summary>
    /// Whether the discount applies on regular one-time-purchase items.
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
    /// The items to which the discount applies.
    /// </summary>
    [JsonPropertyName("items")]
    public DiscountItems? items { get; set; } = null;

    /// <summary>
    /// Entitled quantity and the discount value.
    /// </summary>
    [JsonPropertyName("value")]
    public DiscountCustomerGetsValue? @value { get; set; } = null;
}