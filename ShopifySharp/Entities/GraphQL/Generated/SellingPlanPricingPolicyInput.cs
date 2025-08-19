#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields required to create or update a selling plan pricing policy.
/// </summary>
public record SellingPlanPricingPolicyInput : GraphQLInputObject<SellingPlanPricingPolicyInput>
{
    /// <summary>
    /// Fixed pricing policy details.
    /// </summary>
    [JsonPropertyName("fixed")]
    public SellingPlanFixedPricingPolicyInput? @fixed { get; set; } = null;

    /// <summary>
    /// Recurring pricing policy details.
    /// </summary>
    [JsonPropertyName("recurring")]
    public SellingPlanRecurringPricingPolicyInput? recurring { get; set; } = null;
}