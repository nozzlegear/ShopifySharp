#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a Subscription Billing Policy.
/// </summary>
public record SubscriptionBillingPolicyInput : GraphQLInputObject<SubscriptionBillingPolicyInput>
{
    /// <summary>
    /// Specific anchor dates upon which the billing interval calculations should be made.
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

    /// <summary>
    /// Maximum amount of cycles required in the subscription.
    /// </summary>
    [JsonPropertyName("maxCycles")]
    public int? maxCycles { get; set; } = null;

    /// <summary>
    /// Minimum amount of cycles required in the subscription.
    /// </summary>
    [JsonPropertyName("minCycles")]
    public int? minCycles { get; set; } = null;
}