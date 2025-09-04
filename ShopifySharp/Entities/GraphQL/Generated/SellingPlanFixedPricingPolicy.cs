#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the pricing policy of a subscription or deferred purchase option selling plan.
/// The selling plan fixed pricing policy works with the billing and delivery policy
/// to determine the final price. Discounts are divided among fulfillments.
/// For example, a subscription with a $10 discount and two deliveries will have a $5
/// discount applied to each delivery.
/// </summary>
public record SellingPlanFixedPricingPolicy : IGraphQLUnionCase, IGraphQLObject, ISellingPlanPricingPolicyBase
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
    public SellingPlanPricingPolicyAdjustmentValue? adjustmentValue { get; set; } = null;

    /// <summary>
    /// The date and time when the fixed selling plan pricing policy was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;
}