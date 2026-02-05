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
/// The input fields required to create or update a fixed selling plan pricing policy.
/// </summary>
public record SellingPlanFixedPricingPolicyInput : GraphQLInputObject<SellingPlanFixedPricingPolicyInput>
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
    /// ID of the pricing policy.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}