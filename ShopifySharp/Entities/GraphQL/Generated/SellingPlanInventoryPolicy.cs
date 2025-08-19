#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The selling plan inventory policy.
/// </summary>
public record SellingPlanInventoryPolicy : IGraphQLObject
{
    /// <summary>
    /// When to reserve inventory for the order.
    /// </summary>
    [JsonPropertyName("reserve")]
    public SellingPlanReserve? reserve { get; set; } = null;
}