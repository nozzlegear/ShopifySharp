#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record SubscriptionDeliveryMethodSubscriptionDeliveryMethodLocalDelivery(SubscriptionDeliveryMethodLocalDelivery Value): SubscriptionDeliveryMethod;
internal record SubscriptionDeliveryMethodSubscriptionDeliveryMethodPickup(SubscriptionDeliveryMethodPickup Value): SubscriptionDeliveryMethod;
internal record SubscriptionDeliveryMethodSubscriptionDeliveryMethodShipping(SubscriptionDeliveryMethodShipping Value): SubscriptionDeliveryMethod;
#endif /// <summary>

/// Specifies delivery method fields for a subscription draft.
/// This is an input union: one, and only one, field can be provided.
/// The field provided will determine which delivery method is to be used.
/// </summary>
public record SubscriptionDeliveryMethodInput : GraphQLInputObject<SubscriptionDeliveryMethodInput>
{
    /// <summary>
    /// The input fields for the local delivery method.
    /// </summary>
    [JsonPropertyName("localDelivery")]
    public SubscriptionDeliveryMethodLocalDeliveryInput? localDelivery { get; set; } = null;

    /// <summary>
    /// The input fields for the pickup delivery method.
    /// </summary>
    [JsonPropertyName("pickup")]
    public SubscriptionDeliveryMethodPickupInput? pickup { get; set; } = null;

    /// <summary>
    /// The input fields for the shipping delivery method.
    /// </summary>
    [JsonPropertyName("shipping")]
    public SubscriptionDeliveryMethodShippingInput? shipping { get; set; } = null;
}