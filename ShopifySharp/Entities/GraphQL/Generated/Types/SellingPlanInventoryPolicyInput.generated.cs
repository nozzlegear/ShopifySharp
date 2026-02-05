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