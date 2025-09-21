#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents what a particular discount reduces from a line price.
/// </summary>
public record SubscriptionDiscountAllocation : IGraphQLObject
{
    /// <summary>
    /// Allocation amount.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyV2? amount { get; set; } = null;

    /// <summary>
    /// Discount that created the allocation.
    /// </summary>
    [JsonPropertyName("discount")]
    public SubscriptionDiscount? discount { get; set; } = null;
}