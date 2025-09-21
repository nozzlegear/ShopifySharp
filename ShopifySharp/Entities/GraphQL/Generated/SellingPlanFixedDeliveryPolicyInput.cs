#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to create or update a fixed delivery policy.
/// </summary>
public record SellingPlanFixedDeliveryPolicyInput : GraphQLInputObject<SellingPlanFixedDeliveryPolicyInput>
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
    /// The date and time when the fulfillment should trigger.
    /// </summary>
    [JsonPropertyName("fulfillmentExactTime")]
    public DateTime? fulfillmentExactTime { get; set; } = null;

    /// <summary>
    /// What triggers the fulfillment.
    /// </summary>
    [JsonPropertyName("fulfillmentTrigger")]
    public SellingPlanFulfillmentTrigger? fulfillmentTrigger { get; set; } = null;

    /// <summary>
    /// Whether the delivery policy is merchant or buyer-centric.
    /// </summary>
    [JsonPropertyName("intent")]
    public SellingPlanFixedDeliveryPolicyIntent? intent { get; set; } = null;

    /// <summary>
    /// The pre-anchor behavior.
    /// </summary>
    [JsonPropertyName("preAnchorBehavior")]
    public SellingPlanFixedDeliveryPolicyPreAnchorBehavior? preAnchorBehavior { get; set; } = null;
}