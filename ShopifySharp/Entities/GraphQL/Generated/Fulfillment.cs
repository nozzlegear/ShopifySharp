#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a fulfillment.
/// In Shopify, a fulfillment represents a shipment of one or more items in an order.
/// When an order has been completely fulfilled, it means that all the items that are included
/// in the order have been sent to the customer.
/// There can be more than one fulfillment for an order.
/// </summary>
public record Fulfillment : IGraphQLObject, ILegacyInteroperability, INode
{
    /// <summary>
    /// The date and time when the fulfillment was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The date that this fulfillment was delivered.
    /// </summary>
    [JsonPropertyName("deliveredAt")]
    public DateTime? deliveredAt { get; set; } = null;

    /// <summary>
    /// Human readable display status for this fulfillment.
    /// </summary>
    [JsonPropertyName("displayStatus")]
    public FulfillmentDisplayStatus? displayStatus { get; set; } = null;

    /// <summary>
    /// The estimated date that this fulfillment will arrive.
    /// </summary>
    [JsonPropertyName("estimatedDeliveryAt")]
    public DateTime? estimatedDeliveryAt { get; set; } = null;

    /// <summary>
    /// The history of events associated with this fulfillment.
    /// </summary>
    [JsonPropertyName("events")]
    public FulfillmentEventConnection? events { get; set; } = null;

    /// <summary>
    /// List of the fulfillment's line items.
    /// </summary>
    [JsonPropertyName("fulfillmentLineItems")]
    public FulfillmentLineItemConnection? fulfillmentLineItems { get; set; } = null;

    /// <summary>
    /// A paginated list of fulfillment orders for the fulfillment.
    /// </summary>
    [JsonPropertyName("fulfillmentOrders")]
    public FulfillmentOrderConnection? fulfillmentOrders { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The date and time when the fulfillment went into transit.
    /// </summary>
    [JsonPropertyName("inTransitAt")]
    public DateTime? inTransitAt { get; set; } = null;

    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; } = null;

    /// <summary>
    /// The location that the fulfillment was processed at.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// Human readable reference identifier for this fulfillment.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The order for which the fulfillment was created.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// The address at which the fulfillment occurred. This field is intended for tax
    /// purposes, as a full address is required for tax providers to accurately
    /// calculate taxes. Typically this is the address of the warehouse or fulfillment
    /// center. To retrieve a fulfillment location's address, use the
    /// `assignedLocation` field on the
    /// [`FulfillmentOrder`](/docs/api/admin-graphql/latest/objects/FulfillmentOrder)
    /// object instead.
    /// </summary>
    [JsonPropertyName("originAddress")]
    public FulfillmentOriginAddress? originAddress { get; set; } = null;

    /// <summary>
    /// Whether any of the line items in the fulfillment require shipping.
    /// </summary>
    [JsonPropertyName("requiresShipping")]
    public bool? requiresShipping { get; set; } = null;

    /// <summary>
    /// Fulfillment service associated with the fulfillment.
    /// </summary>
    [JsonPropertyName("service")]
    public FulfillmentService? service { get; set; } = null;

    /// <summary>
    /// The status of the fulfillment.
    /// </summary>
    [JsonPropertyName("status")]
    public FulfillmentStatus? status { get; set; } = null;

    /// <summary>
    /// Sum of all line item quantities for the fulfillment.
    /// </summary>
    [JsonPropertyName("totalQuantity")]
    public int? totalQuantity { get; set; } = null;

    /// <summary>
    /// Tracking information associated with the fulfillment,
    /// such as the tracking company, tracking number, and tracking URL.
    /// </summary>
    [JsonPropertyName("trackingInfo")]
    public ICollection<FulfillmentTrackingInfo>? trackingInfo { get; set; } = null;

    /// <summary>
    /// The date and time when the fulfillment was last modified.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? updatedAt { get; set; } = null;
}