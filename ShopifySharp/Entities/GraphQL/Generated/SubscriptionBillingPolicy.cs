#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a Subscription Billing Policy.
/// </summary>
public record SubscriptionBillingPolicy : IGraphQLObject
{
    /// <summary>
    /// Specific anchor dates upon which the billing interval calculations should be made.
    /// </summary>
    [JsonPropertyName("anchors")]
    public ICollection<SellingPlanAnchor>? anchors { get; set; } = null;

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

    /// <summary>
    /// Maximum amount of cycles after which the subscription ends.
    /// </summary>
    [JsonPropertyName("maxCycles")]
    public int? maxCycles { get; set; } = null;

    /// <summary>
    /// Minimum amount of cycles required in the subscription.
    /// </summary>
    [JsonPropertyName("minCycles")]
    public int? minCycles { get; set; } = null;
}