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
/// An unexpected error that occurred during a subscription billing attempt.
/// </summary>
public record SubscriptionBillingAttemptUnexpectedError : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// A message describing the unexpected error.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;
}