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
/// The input fields used to include the line items of a specified fulfillment order that should be fulfilled.
/// </summary>
public record FulfillmentOrderLineItemsInput : GraphQLInputObject<FulfillmentOrderLineItemsInput>
{
    /// <summary>
    /// The ID of the fulfillment order.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderId")]
    public string? fulfillmentOrderId { get; set; } = null;

    /// <summary>
    /// The fulfillment order line items to be fulfilled.
    /// If left blank, all line items of the fulfillment order will be fulfilled.
    /// Accepts a maximum of 512 line items.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderLineItems")]
    public ICollection<FulfillmentOrderLineItemInput>? fulfillmentOrderLineItems { get; set; } = null;
}