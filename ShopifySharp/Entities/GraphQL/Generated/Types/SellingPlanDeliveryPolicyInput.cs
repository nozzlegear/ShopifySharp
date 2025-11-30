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
/// The input fields that are required to create or update a delivery policy.
/// </summary>
public record SellingPlanDeliveryPolicyInput : GraphQLInputObject<SellingPlanDeliveryPolicyInput>
{
    /// <summary>
    /// The fixed delivery policy details.
    /// </summary>
    [JsonPropertyName("fixed")]
    public SellingPlanFixedDeliveryPolicyInput? @fixed { get; set; } = null;

    /// <summary>
    /// The recurring delivery policy details.
    /// </summary>
    [JsonPropertyName("recurring")]
    public SellingPlanRecurringDeliveryPolicyInput? recurring { get; set; } = null;
}