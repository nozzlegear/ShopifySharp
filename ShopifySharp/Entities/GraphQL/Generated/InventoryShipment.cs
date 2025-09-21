#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents an inventory shipment.
/// </summary>
public record InventoryShipment : IGraphQLObject, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The line items included in this shipment.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public InventoryShipmentLineItemConnection? lineItems { get; set; } = null;

    /// <summary>
    /// The number of line items associated with the inventory shipment. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("lineItemsCount")]
    public Count? lineItemsCount { get; set; } = null;

    /// <summary>
    /// The total quantity of all items in the shipment.
    /// </summary>
    [JsonPropertyName("lineItemTotalQuantity")]
    public int? lineItemTotalQuantity { get; set; } = null;

    /// <summary>
    /// The name of the inventory shipment.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The current status of the shipment.
    /// </summary>
    [JsonPropertyName("status")]
    public InventoryShipmentStatus? status { get; set; } = null;

    /// <summary>
    /// The total quantity of items accepted across all line items in this shipment.
    /// </summary>
    [JsonPropertyName("totalAcceptedQuantity")]
    public int? totalAcceptedQuantity { get; set; } = null;

    /// <summary>
    /// The total quantity of items received (both accepted and rejected) across all line items in this shipment.
    /// </summary>
    [JsonPropertyName("totalReceivedQuantity")]
    public int? totalReceivedQuantity { get; set; } = null;

    /// <summary>
    /// The total quantity of items rejected across all line items in this shipment.
    /// </summary>
    [JsonPropertyName("totalRejectedQuantity")]
    public int? totalRejectedQuantity { get; set; } = null;

    /// <summary>
    /// The tracking information for the shipment.
    /// </summary>
    [JsonPropertyName("tracking")]
    public InventoryShipmentTracking? tracking { get; set; } = null;
}