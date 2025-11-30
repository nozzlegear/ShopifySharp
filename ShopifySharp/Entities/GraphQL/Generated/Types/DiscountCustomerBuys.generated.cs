#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The prerequisite items and prerequisite value that a customer must have on the order for the discount to be applicable.
/// </summary>
public record DiscountCustomerBuys : IGraphQLObject
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
    /// The items required for the discount to be applicable.
    /// </summary>
    [JsonPropertyName("items")]
    public DiscountItems? items { get; set; } = null;

    /// <summary>
    /// The prerequisite value.
    /// </summary>
    [JsonPropertyName("value")]
    public DiscountCustomerBuysValue? @value { get; set; } = null;
}