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
/// Represents a shipping delivery method: a mailing address and a shipping option.
/// </summary>
public record SubscriptionDeliveryMethodShipping : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The address to ship to.
    /// </summary>
    [JsonPropertyName("address")]
    public MailingAddress? address { get; set; } = null;

    /// <summary>
    /// The details of the shipping method to use.
    /// </summary>
    [JsonPropertyName("shippingOption")]
    public SubscriptionDeliveryMethodShippingOption? shippingOption { get; set; } = null;
}