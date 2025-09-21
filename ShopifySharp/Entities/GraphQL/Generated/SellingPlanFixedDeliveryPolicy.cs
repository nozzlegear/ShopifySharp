#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a fixed selling plan delivery policy.
/// </summary>
public record SellingPlanFixedDeliveryPolicy : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The specific anchor dates upon which the delivery interval calculations should be made.
    /// </summary>
    [JsonPropertyName("anchors")]
    public ICollection<SellingPlanAnchor>? anchors { get; set; } = null;

    /// <summary>
    /// A buffer period for orders to be included in next fulfillment anchor.
    /// </summary>
    [JsonPropertyName("cutoff")]
    public int? cutoff { get; set; } = null;

    /// <summary>
    /// The date and time when the fulfillment should trigger.
    /// </summary>
    [JsonPropertyName("fulfillmentExactTime")]
    public DateTime? fulfillmentExactTime { get; set; } = null;

    /// <summary>
    /// What triggers the fulfillment. The value must be one of ANCHOR, ASAP, EXACT_TIME, or UNKNOWN.
    /// </summary>
    [JsonPropertyName("fulfillmentTrigger")]
    public SellingPlanFulfillmentTrigger? fulfillmentTrigger { get; set; } = null;

    /// <summary>
    /// Whether the delivery policy is merchant or buyer-centric.
    /// Buyer-centric delivery policies state the time when the buyer will receive the goods.
    /// Merchant-centric delivery policies state the time when the fulfillment should be started.
    /// Currently, only merchant-centric delivery policies are supported.
    /// </summary>
    [JsonPropertyName("intent")]
    public SellingPlanFixedDeliveryPolicyIntent? intent { get; set; } = null;

    /// <summary>
    /// The fulfillment or delivery behavior of the first fulfillment when the order
    /// is placed before the anchor. The default value for this field is `ASAP`.
    /// </summary>
    [JsonPropertyName("preAnchorBehavior")]
    public SellingPlanFixedDeliveryPolicyPreAnchorBehavior? preAnchorBehavior { get; set; } = null;
}