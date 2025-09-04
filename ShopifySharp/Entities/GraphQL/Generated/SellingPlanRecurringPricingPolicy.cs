#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a recurring selling plan pricing policy. It applies after the fixed
/// pricing policy. By using the afterCycle parameter, you can specify the cycle
/// when the recurring pricing policy comes into effect. Recurring pricing policies
/// are not available for deferred purchase options.
/// </summary>
public record SellingPlanRecurringPricingPolicy : IGraphQLUnionCase, IGraphQLObject, ISellingPlanPricingPolicyBase
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
    /// Cycle after which this pricing policy applies.
    /// </summary>
    [JsonPropertyName("afterCycle")]
    public int? afterCycle { get; set; } = null;

    /// <summary>
    /// The date and time when the recurring selling plan pricing policy was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;
}