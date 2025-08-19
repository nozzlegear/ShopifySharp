#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `subscriptionBillingCycleUnskip` mutation.
/// </summary>
public record SubscriptionBillingCycleUnskipPayload : IGraphQLObject
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
    public ICollection<SubscriptionBillingCycleUnskipUserError>? userErrors { get; set; } = null;
}