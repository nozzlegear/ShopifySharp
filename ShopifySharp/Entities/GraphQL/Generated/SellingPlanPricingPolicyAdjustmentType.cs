#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record SellingPlanPricingPolicySellingPlanFixedPricingPolicy(SellingPlanFixedPricingPolicy Value): SellingPlanPricingPolicy;
internal record SellingPlanPricingPolicySellingPlanRecurringPricingPolicy(SellingPlanRecurringPricingPolicy Value): SellingPlanPricingPolicy;
#endif /// <summary>

/// Represents a selling plan pricing policy adjustment type.
/// </summary>
public enum SellingPlanPricingPolicyAdjustmentType
{
    PERCENTAGE,
    FIXED_AMOUNT,
    PRICE,
}