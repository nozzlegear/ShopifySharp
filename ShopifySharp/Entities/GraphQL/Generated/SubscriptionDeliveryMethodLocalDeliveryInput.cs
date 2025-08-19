#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a local delivery method.
/// This input accepts partial input. When a field is not provided,
/// its prior value is left unchanged.
/// </summary>
public record SubscriptionDeliveryMethodLocalDeliveryInput : GraphQLInputObject<SubscriptionDeliveryMethodLocalDeliveryInput>
{
    /// <summary>
    /// The address to deliver to.
    /// </summary>
    [JsonPropertyName("address")]
    public MailingAddressInput? address { get; set; } = null;

    /// <summary>
    /// The details of the local delivery method to use.
    /// </summary>
    [JsonPropertyName("localDeliveryOption")]
    public SubscriptionDeliveryMethodLocalDeliveryOptionInput? localDeliveryOption { get; set; } = null;
}