#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a recurring selling plan delivery policy.
/// </summary>
public record SellingPlanRecurringDeliveryPolicy : SellingPlanDeliveryPolicy, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The specific anchor dates upon which the delivery interval calculations should be made.
    /// </summary>
    [JsonPropertyName("anchors")]
    public ICollection<SellingPlanAnchor>? anchors { get; set; } = null;

    /// <summary>
    /// The date and time when the selling plan delivery policy was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// Number of days which represent a buffer period for orders to be included in a cycle.
    /// </summary>
    [JsonPropertyName("cutoff")]
    public int? cutoff { get; set; } = null;

    /// <summary>
    /// Whether the delivery policy is merchant or buyer-centric.
    /// Buyer-centric delivery policies state the time when the buyer will receive the goods.
    /// Merchant-centric delivery policies state the time when the fulfillment should be started.
    /// Currently, only merchant-centric delivery policies are supported.
    /// </summary>
    [JsonPropertyName("intent")]
    public SellingPlanRecurringDeliveryPolicyIntent? intent { get; set; } = null;

    /// <summary>
    /// The delivery frequency, it can be either: day, week, month or year.
    /// </summary>
    [JsonPropertyName("interval")]
    public SellingPlanInterval? interval { get; set; } = null;

    /// <summary>
    /// The number of intervals between deliveries.
    /// </summary>
    [JsonPropertyName("intervalCount")]
    public int? intervalCount { get; set; } = null;

    /// <summary>
    /// The fulfillment or delivery behavior of the first fulfillment when the order
    /// is placed before the anchor. The default value for this field is `ASAP`.
    /// </summary>
    [JsonPropertyName("preAnchorBehavior")]
    public SellingPlanRecurringDeliveryPolicyPreAnchorBehavior? preAnchorBehavior { get; set; } = null;
}