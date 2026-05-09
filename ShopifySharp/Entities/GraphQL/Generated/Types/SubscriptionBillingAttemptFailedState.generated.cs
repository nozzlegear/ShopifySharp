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
/// The billing attempt failed due to an error.
/// </summary>
public record SubscriptionBillingAttemptFailedState : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The error that caused the billing attempt to fail.
    /// </summary>
    [JsonPropertyName("error")]
    public SubscriptionBillingAttemptError? error { get; set; } = null;
}