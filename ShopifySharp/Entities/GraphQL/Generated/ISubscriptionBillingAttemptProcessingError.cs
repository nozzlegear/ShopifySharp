#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// An error that prevented a billing attempt.
/// </summary>
public interface ISubscriptionBillingAttemptProcessingError : IGraphQLObject
{
    /// <summary>
    /// The code for the error.
    /// </summary>
    [JsonPropertyName("code")]
    public SubscriptionBillingAttemptErrorCode? code { get; set; }

    /// <summary>
    /// An explanation of the error.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; }
}