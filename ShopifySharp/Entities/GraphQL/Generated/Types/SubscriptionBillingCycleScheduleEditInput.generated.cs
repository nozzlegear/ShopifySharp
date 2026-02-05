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
/// The input fields for parameters to modify the schedule of a specific billing cycle.
/// </summary>
public record SubscriptionBillingCycleScheduleEditInput : GraphQLInputObject<SubscriptionBillingCycleScheduleEditInput>
{
    /// <summary>
    /// Sets the expected billing date for the billing cycle.
    /// </summary>
    [JsonPropertyName("billingDate")]
    public DateTimeOffset? billingDate { get; set; } = null;

    /// <summary>
    /// The reason for editing.
    /// </summary>
    [JsonPropertyName("reason")]
    public SubscriptionBillingCycleScheduleEditInputScheduleEditReason? reason { get; set; } = null;

    /// <summary>
    /// Sets the skip status for the billing cycle.
    /// </summary>
    [JsonPropertyName("skip")]
    public bool? skip { get; set; } = null;
}