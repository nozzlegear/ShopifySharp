#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A group of one or more items in a return that will be processed at a fulfillment service.
/// There can be more than one reverse fulfillment order for a return at a given location.
/// </summary>
public record ReverseFulfillmentOrder : IGraphQLObject, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The list of reverse fulfillment order line items for the reverse fulfillment order.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public ReverseFulfillmentOrderLineItemConnection? lineItems { get; set; } = null;

    /// <summary>
    /// The order associated with the reverse fulfillment order.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// The list of reverse deliveries for the reverse fulfillment order.
    /// </summary>
    [JsonPropertyName("reverseDeliveries")]
    public ReverseDeliveryConnection? reverseDeliveries { get; set; } = null;

    /// <summary>
    /// The status of the reverse fulfillment order.
    /// </summary>
    [JsonPropertyName("status")]
    public ReverseFulfillmentOrderStatus? status { get; set; } = null;

    /// <summary>
    /// The current confirmation for the reverse fulfillment order from a third-party logistics service. 
    /// If no third-party service is involved, then this value is `nil`.
    /// </summary>
    [JsonPropertyName("thirdPartyConfirmation")]
    public ReverseFulfillmentOrderThirdPartyConfirmation? thirdPartyConfirmation { get; set; } = null;
}