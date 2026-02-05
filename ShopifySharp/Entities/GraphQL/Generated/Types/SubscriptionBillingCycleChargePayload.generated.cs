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
/// Return type for `subscriptionBillingCycleCharge` mutation.
/// </summary>
public record SubscriptionBillingCycleChargePayload : IGraphQLObject
{
    /// <summary>
    /// The subscription billing attempt.
    /// </summary>
    [JsonPropertyName("subscriptionBillingAttempt")]
    public SubscriptionBillingAttempt? subscriptionBillingAttempt { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BillingAttemptUserError>? userErrors { get; set; } = null;
}