#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A delivery method with a pickup option.
/// </summary>
public record SubscriptionDeliveryMethodPickup : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The details of the pickup delivery method to use.
    /// </summary>
    [JsonPropertyName("pickupOption")]
    public SubscriptionDeliveryMethodPickupOption? pickupOption { get; set; } = null;
}