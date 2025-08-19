#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `subscriptionBillingCycleScheduleEdit` mutation.
/// </summary>
public record SubscriptionBillingCycleScheduleEditPayload : IGraphQLObject
{
    /// <summary>
    /// The updated billing cycle.
    /// </summary>
    [JsonPropertyName("billingCycle")]
    public SubscriptionBillingCycle? billingCycle { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<SubscriptionBillingCycleUserError>? userErrors { get; set; } = null;
}