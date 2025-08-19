#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The delivery option for a subscription contract.
/// </summary>
public record SubscriptionDeliveryOptionResultSuccess : SubscriptionDeliveryOptionResult, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The available delivery options.
    /// </summary>
    [JsonPropertyName("deliveryOptions")]
    public ICollection<SubscriptionDeliveryOption>? deliveryOptions { get; set; } = null;
}