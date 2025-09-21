#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A base error type that applies to all uncategorized error classes.
/// </summary>
public record SubscriptionBillingAttemptGenericError : IGraphQLObject, ISubscriptionBillingAttemptProcessingError
{
    /// <summary>
    /// The code for the error.
    /// </summary>
    [JsonPropertyName("code")]
    public SubscriptionBillingAttemptErrorCode? code { get; set; } = null;

    /// <summary>
    /// An explanation of the error.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;
}