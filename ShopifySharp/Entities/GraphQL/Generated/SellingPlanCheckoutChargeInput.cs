#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields that are required to create or update a checkout charge.
/// </summary>
public record SellingPlanCheckoutChargeInput : GraphQLInputObject<SellingPlanCheckoutChargeInput>
{
    /// <summary>
    /// The checkout charge type defined by the policy.
    /// </summary>
    [JsonPropertyName("type")]
    public SellingPlanCheckoutChargeType? type { get; set; } = null;

    /// <summary>
    /// The checkout charge value defined by the policy.
    /// </summary>
    [JsonPropertyName("value")]
    public SellingPlanCheckoutChargeValueInput? @value { get; set; } = null;
}