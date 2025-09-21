#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a Subscription Line Pricing Cycle Adjustment.
/// </summary>
public record SubscriptionCyclePriceAdjustment : IGraphQLObject
{
    /// <summary>
    /// Price adjustment type.
    /// </summary>
    [JsonPropertyName("adjustmentType")]
    public SellingPlanPricingPolicyAdjustmentType? adjustmentType { get; set; } = null;

    /// <summary>
    /// Price adjustment value.
    /// </summary>
    [JsonPropertyName("adjustmentValue")]
    public SellingPlanPricingPolicyAdjustmentValue? adjustmentValue { get; set; } = null;

    /// <summary>
    /// The number of cycles required before this pricing policy applies.
    /// </summary>
    [JsonPropertyName("afterCycle")]
    public int? afterCycle { get; set; } = null;

    /// <summary>
    /// The computed price after the adjustments applied.
    /// </summary>
    [JsonPropertyName("computedPrice")]
    public MoneyV2? computedPrice { get; set; } = null;
}