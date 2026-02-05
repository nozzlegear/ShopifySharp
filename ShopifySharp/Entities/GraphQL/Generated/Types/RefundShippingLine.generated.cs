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
/// A shipping line item that's included in a refund.
/// </summary>
public record RefundShippingLine : IGraphQLObject, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The `ShippingLine` resource associated to the refunded shipping line item.
    /// </summary>
    [JsonPropertyName("shippingLine")]
    public ShippingLine? shippingLine { get; set; } = null;

    /// <summary>
    /// The subtotal amount of the refund shipping line in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("subtotalAmountSet")]
    public MoneyBag? subtotalAmountSet { get; set; } = null;

    /// <summary>
    /// The tax amount of the refund shipping line in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("taxAmountSet")]
    public MoneyBag? taxAmountSet { get; set; } = null;
}