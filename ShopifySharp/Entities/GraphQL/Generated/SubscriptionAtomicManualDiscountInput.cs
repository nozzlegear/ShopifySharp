#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for mapping a subscription line to a discount.
/// </summary>
public record SubscriptionAtomicManualDiscountInput : GraphQLInputObject<SubscriptionAtomicManualDiscountInput>
{
    /// <summary>
    /// The maximum number of times the subscription discount will be applied on orders.
    /// </summary>
    [JsonPropertyName("recurringCycleLimit")]
    public int? recurringCycleLimit { get; set; } = null;

    /// <summary>
    /// The title associated with the subscription discount.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// Percentage or fixed amount value of the discount.
    /// </summary>
    [JsonPropertyName("value")]
    public SubscriptionManualDiscountValueInput? @value { get; set; } = null;
}