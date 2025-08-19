#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for an array containing all pricing changes for each billing cycle.
/// </summary>
public record SubscriptionPricingPolicyCycleDiscountsInput : GraphQLInputObject<SubscriptionPricingPolicyCycleDiscountsInput>
{
    /// <summary>
    /// The price adjustment type.
    /// </summary>
    [JsonPropertyName("adjustmentType")]
    public SellingPlanPricingPolicyAdjustmentType? adjustmentType { get; set; } = null;

    /// <summary>
    /// The price adjustment value.
    /// </summary>
    [JsonPropertyName("adjustmentValue")]
    public SellingPlanPricingPolicyValueInput? adjustmentValue { get; set; } = null;

    /// <summary>
    /// The cycle after which the pricing policy applies.
    /// </summary>
    [JsonPropertyName("afterCycle")]
    public int? afterCycle { get; set; } = null;

    /// <summary>
    /// The computed price after the adjustments are applied.
    /// </summary>
    [JsonPropertyName("computedPrice")]
    public decimal? computedPrice { get; set; } = null;
}