#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record SellingPlanBillingPolicySellingPlanFixedBillingPolicy(SellingPlanFixedBillingPolicy Value): SellingPlanBillingPolicy;
internal record SellingPlanBillingPolicySellingPlanRecurringBillingPolicy(SellingPlanRecurringBillingPolicy Value): SellingPlanBillingPolicy;
#endif /// <summary>

/// The input fields that are required to create or update a billing policy type.
/// </summary>
public record SellingPlanBillingPolicyInput : GraphQLInputObject<SellingPlanBillingPolicyInput>
{
    /// <summary>
    /// The fixed billing policy details.
    /// </summary>
    [JsonPropertyName("fixed")]
    public SellingPlanFixedBillingPolicyInput? @fixed { get; set; } = null;

    /// <summary>
    /// The recurring billing policy details.
    /// </summary>
    [JsonPropertyName("recurring")]
    public SellingPlanRecurringBillingPolicyInput? recurring { get; set; } = null;
}