#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A shipping line removed during an order edit.
/// </summary>
public record OrderStagedChangeRemoveShippingLine : OrderStagedChange, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The removed shipping line.
    /// </summary>
    [JsonPropertyName("shippingLine")]
    public ShippingLine? shippingLine { get; set; } = null;
}