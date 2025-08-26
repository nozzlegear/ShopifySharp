#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a selling plan pricing policy adjustment type.
/// </summary>
public enum SellingPlanPricingPolicyAdjustmentType
{
    PERCENTAGE,
    FIXED_AMOUNT,
    PRICE,
}