#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `subscriptionBillingAttemptCreate` mutation.
/// </summary>
public record SubscriptionBillingAttemptCreatePayload : IGraphQLObject
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