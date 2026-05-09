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
/// A payment-related error that occurred during a subscription billing attempt.
/// </summary>
public record SubscriptionBillingAttemptPaymentError : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The error code for the payment failure.
    /// </summary>
    [JsonPropertyName("code")]
    public SubscriptionBillingAttemptPaymentErrorCode? code { get; set; } = null;
}