#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `subscriptionBillingCycleBulkCharge` mutation.
/// </summary>
public record SubscriptionBillingCycleBulkChargePayload : IGraphQLObject
{
    /// <summary>
    /// The asynchronous job that performs the action on the targeted billing cycles.
    /// </summary>
    [JsonPropertyName("job")]
    public Job? job { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<SubscriptionBillingCycleBulkUserError>? userErrors { get; set; } = null;
}