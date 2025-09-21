#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a Subscription Delivery Policy.
/// </summary>
public record SubscriptionDeliveryPolicy : IGraphQLObject
{
    /// <summary>
    /// The specific anchor dates upon which the delivery interval calculations should be made.
    /// </summary>
    [JsonPropertyName("anchors")]
    public ICollection<SellingPlanAnchor>? anchors { get; set; } = null;

    /// <summary>
    /// The kind of interval that's associated with this schedule (e.g. Monthly, Weekly, etc).
    /// </summary>
    [JsonPropertyName("interval")]
    public SellingPlanInterval? interval { get; set; } = null;

    /// <summary>
    /// The number of delivery intervals between deliveries.
    /// </summary>
    [JsonPropertyName("intervalCount")]
    public int? intervalCount { get; set; } = null;
}