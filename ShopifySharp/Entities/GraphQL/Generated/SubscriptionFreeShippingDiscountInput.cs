#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a subscription free shipping discount on a contract.
/// </summary>
public record SubscriptionFreeShippingDiscountInput : GraphQLInputObject<SubscriptionFreeShippingDiscountInput>
{
    /// <summary>
    /// The maximum number of times the subscription free shipping discount will be applied on orders.
    /// </summary>
    [JsonPropertyName("recurringCycleLimit")]
    public int? recurringCycleLimit { get; set; } = null;

    /// <summary>
    /// The title associated with the subscription free shipping discount.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}