#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents an error that happens during the execution of subscriptionBillingCycles mutations.
/// </summary>
public record SubscriptionBillingCycleBulkUserError : IGraphQLObject, IDisplayableError
{
    /// <summary>
    /// The error code.
    /// </summary>
    [JsonPropertyName("code")]
    public SubscriptionBillingCycleBulkUserErrorCode? code { get; set; } = null;

    /// <summary>
    /// The path to the input field that caused the error.
    /// </summary>
    [JsonPropertyName("field")]
    public ICollection<string>? field { get; set; } = null;

    /// <summary>
    /// The error message.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;
}