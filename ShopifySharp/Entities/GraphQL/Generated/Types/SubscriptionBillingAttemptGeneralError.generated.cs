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
/// An error that occurred during a subscription billing attempt that doesn't fit other categories.
/// </summary>
public record SubscriptionBillingAttemptGeneralError : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The error code for the failure.
    /// </summary>
    [JsonPropertyName("code")]
    public SubscriptionBillingAttemptGeneralErrorCode? code { get; set; } = null;
}