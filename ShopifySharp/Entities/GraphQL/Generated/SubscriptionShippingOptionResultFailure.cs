#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Failure determining available shipping options for delivery of a subscription contract.
/// </summary>
public record SubscriptionShippingOptionResultFailure : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// Failure reason.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;
}