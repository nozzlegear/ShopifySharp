#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a pickup delivery method.
/// This input accepts partial input. When a field is not provided,
/// its prior value is left unchanged.
/// </summary>
public record SubscriptionDeliveryMethodPickupInput : GraphQLInputObject<SubscriptionDeliveryMethodPickupInput>
{
    /// <summary>
    /// The details of the pickup method to use.
    /// </summary>
    [JsonPropertyName("pickupOption")]
    public SubscriptionDeliveryMethodPickupOptionInput? pickupOption { get; set; } = null;
}