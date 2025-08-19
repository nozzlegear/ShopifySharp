#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Discount applied to the recurring pricing portion of a subscription.
/// </summary>
public record AppSubscriptionDiscount : IGraphQLObject
{
    /// <summary>
    /// The total number of billing intervals to which the discount will be applied.
    /// The discount will be applied to an indefinite number of billing intervals if this value is blank.
    /// </summary>
    [JsonPropertyName("durationLimitInIntervals")]
    public int? durationLimitInIntervals { get; set; } = null;

    /// <summary>
    /// The price of the subscription after the discount is applied.
    /// </summary>
    [JsonPropertyName("priceAfterDiscount")]
    public MoneyV2? priceAfterDiscount { get; set; } = null;

    /// <summary>
    /// The remaining number of billing intervals to which the discount will be applied.
    /// </summary>
    [JsonPropertyName("remainingDurationInIntervals")]
    public int? remainingDurationInIntervals { get; set; } = null;

    /// <summary>
    /// The value of the discount applied every billing interval.
    /// </summary>
    [JsonPropertyName("value")]
    public AppSubscriptionDiscountValue? @value { get; set; } = null;
}