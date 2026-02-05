#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Specifies shipping delivery method fields.
/// This input accepts partial input. When a field is not provided,
/// its prior value is left unchanged.
/// </summary>
public record SubscriptionDeliveryMethodShippingInput : GraphQLInputObject<SubscriptionDeliveryMethodShippingInput>
{
    /// <summary>
    /// The address to ship to.
    /// </summary>
    [JsonPropertyName("address")]
    public MailingAddressInput? address { get; set; } = null;

    /// <summary>
    /// The details of the shipping method to use.
    /// </summary>
    [JsonPropertyName("shippingOption")]
    public SubscriptionDeliveryMethodShippingOptionInput? shippingOption { get; set; } = null;
}