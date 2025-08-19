#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record SubscriptionShippingOptionResultSubscriptionShippingOptionResultFailure(SubscriptionShippingOptionResultFailure Value): SubscriptionShippingOptionResult;
internal record SubscriptionShippingOptionResultSubscriptionShippingOptionResultSuccess(SubscriptionShippingOptionResultSuccess Value): SubscriptionShippingOptionResult;
#endif /// <summary>

/// Failure determining available shipping options for delivery of a subscription contract.
/// </summary>
public record SubscriptionShippingOptionResultFailure : SubscriptionShippingOptionResult, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// Failure reason.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;
}