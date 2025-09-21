#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to create or update a recurring delivery policy.
/// </summary>
public record SellingPlanRecurringDeliveryPolicyInput : GraphQLInputObject<SellingPlanRecurringDeliveryPolicyInput>
{
    /// <summary>
    /// The specific anchor dates upon which the delivery interval calculations should be made.
    /// </summary>
    [JsonPropertyName("anchors")]
    public ICollection<SellingPlanAnchorInput>? anchors { get; set; } = null;

    /// <summary>
    /// A buffer period for orders to be included in a cycle.
    /// </summary>
    [JsonPropertyName("cutoff")]
    public int? cutoff { get; set; } = null;

    /// <summary>
    /// Intention of this delivery policy, it can be either: delivery or fulfillment.
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
    /// The pre-anchor behavior. It can be either: asap or next.
    /// </summary>
    [JsonPropertyName("preAnchorBehavior")]
    public SellingPlanRecurringDeliveryPolicyPreAnchorBehavior? preAnchorBehavior { get; set; } = null;
}