#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A shipping option for delivery of a subscription contract.
/// </summary>
public record SubscriptionShippingOptionResultSuccess : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// Available shipping options.
    /// </summary>
    [JsonPropertyName("shippingOptions")]
    public ICollection<SubscriptionShippingOption>? shippingOptions { get; set; } = null;
}