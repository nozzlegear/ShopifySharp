#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record SubscriptionDeliveryOptionResultSubscriptionDeliveryOptionResultFailure(SubscriptionDeliveryOptionResultFailure Value): SubscriptionDeliveryOptionResult;
internal record SubscriptionDeliveryOptionResultSubscriptionDeliveryOptionResultSuccess(SubscriptionDeliveryOptionResultSuccess Value): SubscriptionDeliveryOptionResult;
#endif /// <summary>

/// A failure to find the available delivery options for a subscription contract.
/// </summary>
public record SubscriptionDeliveryOptionResultFailure : SubscriptionDeliveryOptionResult, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The reason for the failure.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;
}