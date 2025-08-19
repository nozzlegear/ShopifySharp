#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Price reduction allocations across the draft order's lines.
/// </summary>
public record DraftOrderPlatformDiscountAllocation : IGraphQLObject
{
    /// <summary>
    /// The ID of the allocation.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The quantity of the target being discounted.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// Amount of the discount allocated to the target.
    /// </summary>
    [JsonPropertyName("reductionAmount")]
    public MoneyV2? reductionAmount { get; set; } = null;

    /// <summary>
    /// Amount of the discount allocated to the target in both shop currency and presentment currency.
    /// </summary>
    [JsonPropertyName("reductionAmountSet")]
    public MoneyBag? reductionAmountSet { get; set; } = null;

    /// <summary>
    /// The element of the draft being discounted.
    /// </summary>
    [JsonPropertyName("target")]
    public DraftOrderPlatformDiscountAllocationTarget? target { get; set; } = null;
}