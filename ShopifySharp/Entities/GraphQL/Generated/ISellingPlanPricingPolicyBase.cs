#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record SellingPlanPricingPolicyAdjustmentValueMoneyV2(MoneyV2 Value): SellingPlanPricingPolicyAdjustmentValue;
internal record SellingPlanPricingPolicyAdjustmentValueSellingPlanPricingPolicyPercentageValue(SellingPlanPricingPolicyPercentageValue Value): SellingPlanPricingPolicyAdjustmentValue;
#endif /// <summary>

/// Represents selling plan pricing policy common fields.
/// </summary>
public interface ISellingPlanPricingPolicyBase : IGraphQLObject
{
    /// <summary>
    /// The price adjustment type.
    /// </summary>
    [JsonPropertyName("adjustmentType")]
    public SellingPlanPricingPolicyAdjustmentType? adjustmentType { get; set; }

    /// <summary>
    /// The price adjustment value.
    /// </summary>
    [JsonPropertyName("adjustmentValue")]
    public SellingPlanPricingPolicyAdjustmentValue? adjustmentValue { get; set; }
}