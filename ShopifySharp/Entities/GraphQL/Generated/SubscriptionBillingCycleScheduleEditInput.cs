#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for parameters to modify the schedule of a specific billing cycle.
/// </summary>
public record SubscriptionBillingCycleScheduleEditInput : GraphQLInputObject<SubscriptionBillingCycleScheduleEditInput>
{
    /// <summary>
    /// Sets the expected billing date for the billing cycle.
    /// </summary>
    [JsonPropertyName("billingDate")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? billingDate { get; set; } = null;

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