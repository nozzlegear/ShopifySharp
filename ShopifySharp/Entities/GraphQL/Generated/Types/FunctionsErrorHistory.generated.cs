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
/// The error history from running a Shopify Function.
/// </summary>
public record FunctionsErrorHistory : IGraphQLObject
{
    /// <summary>
    /// The date and time that the first error occurred.
    /// </summary>
    [JsonPropertyName("errorsFirstOccurredAt")]
    public DateTimeOffset? errorsFirstOccurredAt { get; set; } = null;

    /// <summary>
    /// The date and time that the first error occurred.
    /// </summary>
    [JsonPropertyName("firstOccurredAt")]
    public DateTimeOffset? firstOccurredAt { get; set; } = null;

    /// <summary>
    /// Whether the merchant has shared all the recent errors with the developer.
    /// </summary>
    [JsonPropertyName("hasBeenSharedSinceLastError")]
    public bool? hasBeenSharedSinceLastError { get; set; } = null;

    /// <summary>
    /// Whether the merchant has shared all the recent errors with the developer.
    /// </summary>
    [JsonPropertyName("hasSharedRecentErrors")]
    public bool? hasSharedRecentErrors { get; set; } = null;
}