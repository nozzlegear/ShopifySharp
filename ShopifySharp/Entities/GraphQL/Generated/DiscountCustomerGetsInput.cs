#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Specifies the items that will be discounted, the quantity of items that will be discounted, and the value of discount.
/// </summary>
public record DiscountCustomerGetsInput : GraphQLInputObject<DiscountCustomerGetsInput>
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
    /// The IDs of the items that the customer gets. The items can be either collections or products.
    /// </summary>
    [JsonPropertyName("items")]
    public DiscountItemsInput? items { get; set; } = null;

    /// <summary>
    /// The quantity of items discounted and the discount value.
    /// </summary>
    [JsonPropertyName("value")]
    public DiscountCustomerGetsValueInput? @value { get; set; } = null;
}