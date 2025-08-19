#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `subscriptionBillingCycleEditDelete` mutation.
/// </summary>
public record SubscriptionBillingCycleEditDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The list of updated billing cycles.
    /// </summary>
    [JsonPropertyName("billingCycles")]
    public ICollection<SubscriptionBillingCycle>? billingCycles { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<SubscriptionBillingCycleUserError>? userErrors { get; set; } = null;
}