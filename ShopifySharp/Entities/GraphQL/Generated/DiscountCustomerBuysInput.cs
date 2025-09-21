#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for prerequisite items and quantity for the discount.
/// </summary>
public record DiscountCustomerBuysInput : GraphQLInputObject<DiscountCustomerBuysInput>
{
    /// <summary>
    /// If the discount is applicable when a customer buys a one-time purchase.
    /// </summary>
    [JsonPropertyName("isOneTimePurchase")]
    public bool? isOneTimePurchase { get; set; } = null;

    /// <summary>
    /// If the discount is applicable when a customer buys a subscription purchase.
    /// </summary>
    [JsonPropertyName("isSubscription")]
    public bool? isSubscription { get; set; } = null;

    /// <summary>
    /// The IDs of items that the customer buys. The items can be either collections or products.
    /// </summary>
    [JsonPropertyName("items")]
    public DiscountItemsInput? items { get; set; } = null;

    /// <summary>
    /// The quantity of prerequisite items.
    /// </summary>
    [JsonPropertyName("value")]
    public DiscountCustomerBuysValueInput? @value { get; set; } = null;
}