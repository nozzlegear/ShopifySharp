#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields required to create or update an inventory policy.
/// </summary>
public record SellingPlanInventoryPolicyInput : GraphQLInputObject<SellingPlanInventoryPolicyInput>
{
    /// <summary>
    /// When to reserve inventory for the order. The value must be ON_FULFILLMENT or ON_SALE.
    /// </summary>
    [JsonPropertyName("reserve")]
    public SellingPlanReserve? reserve { get; set; } = null;
}