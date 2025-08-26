#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
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