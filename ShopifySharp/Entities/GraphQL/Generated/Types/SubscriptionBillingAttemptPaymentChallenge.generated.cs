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
/// A payment challenge that the customer must complete.
/// </summary>
public record SubscriptionBillingAttemptPaymentChallenge : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// URL to redirect the customer for authentication.
    /// </summary>
    [JsonPropertyName("nextActionUrl")]
    public string? nextActionUrl { get; set; } = null;

    /// <summary>
    /// The status of the payment challenge.
    /// </summary>
    [JsonPropertyName("status")]
    public SubscriptionBillingAttemptPaymentChallengeStatus? status { get; set; } = null;
}