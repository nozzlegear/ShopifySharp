#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A failure to find the available delivery options for a subscription contract.
/// </summary>
public record SubscriptionDeliveryOptionResultFailure : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The reason for the failure.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;
}