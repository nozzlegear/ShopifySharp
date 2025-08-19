#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A subscription delivery method for local delivery.
/// The other subscription delivery methods can be found in the `SubscriptionDeliveryMethod` union type.
/// </summary>
public record SubscriptionDeliveryMethodLocalDelivery : SubscriptionDeliveryMethod, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The address to deliver to.
    /// </summary>
    [JsonPropertyName("address")]
    public MailingAddress? address { get; set; } = null;

    /// <summary>
    /// The details of the local delivery method to use.
    /// </summary>
    [JsonPropertyName("localDeliveryOption")]
    public SubscriptionDeliveryMethodLocalDeliveryOption? localDeliveryOption { get; set; } = null;
}