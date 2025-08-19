#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a Subscription Delivery Policy.
/// </summary>
public record SubscriptionDeliveryPolicyInput : GraphQLInputObject<SubscriptionDeliveryPolicyInput>
{
    /// <summary>
    /// The specific anchor dates upon which the delivery interval calculations should be made.
    /// </summary>
    [JsonPropertyName("anchors")]
    public ICollection<SellingPlanAnchorInput>? anchors { get; set; } = null;

    /// <summary>
    /// The kind of interval that's associated with this schedule (e.g. Monthly, Weekly, etc).
    /// </summary>
    [JsonPropertyName("interval")]
    public SellingPlanInterval? interval { get; set; } = null;

    /// <summary>
    /// The number of billing intervals between invoices.
    /// </summary>
    [JsonPropertyName("intervalCount")]
    public int? intervalCount { get; set; } = null;
}