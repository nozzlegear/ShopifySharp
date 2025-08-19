#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A returnable fulfillment, which is an order that has been delivered
/// and is eligible to be returned to the merchant.
/// </summary>
public record ReturnableFulfillment : IGraphQLObject, INode
{
    /// <summary>
    /// The fulfillment that the returnable fulfillment refers to.
    /// </summary>
    [JsonPropertyName("fulfillment")]
    public Fulfillment? fulfillment { get; set; } = null;

    /// <summary>
    /// The unique ID of the Returnable Fulfillment.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The list of returnable fulfillment line items.
    /// </summary>
    [JsonPropertyName("returnableFulfillmentLineItems")]
    public ReturnableFulfillmentLineItemConnection? returnableFulfillmentLineItems { get; set; } = null;
}