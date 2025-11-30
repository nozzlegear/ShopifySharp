#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to create or update a recurring selling plan pricing policy.
/// </summary>
public record SellingPlanRecurringPricingPolicyInput : GraphQLInputObject<SellingPlanRecurringPricingPolicyInput>
{
    /// <summary>
    /// Price adjustment type defined by the policy.
    /// </summary>
    [JsonPropertyName("adjustmentType")]
    public SellingPlanPricingPolicyAdjustmentType? adjustmentType { get; set; } = null;

    /// <summary>
    /// Price adjustment value defined by the policy.
    /// </summary>
    [JsonPropertyName("adjustmentValue")]
    public SellingPlanPricingPolicyValueInput? adjustmentValue { get; set; } = null;

    /// <summary>
    /// Cycle after which the pricing policy applies.
    /// </summary>
    [JsonPropertyName("afterCycle")]
    public int? afterCycle { get; set; } = null;

    /// <summary>
    /// ID of the pricing policy.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}