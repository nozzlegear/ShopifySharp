#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A location that a fulfillment order can potentially move to.
/// </summary>
public record FulfillmentOrderLocationForMove : IGraphQLObject
{
    /// <summary>
    /// Fulfillment order line items that can be moved from their current location to the given location.
    /// </summary>
    [JsonPropertyName("availableLineItems")]
    public FulfillmentOrderLineItemConnection? availableLineItems { get; set; } = null;

    /// <summary>
    /// Total number of fulfillment order line items that can be moved from their current assigned location to the
    /// given location.
    /// </summary>
    [JsonPropertyName("availableLineItemsCount")]
    public Count? availableLineItemsCount { get; set; } = null;

    /// <summary>
    /// The location being considered as the fulfillment order's new assigned location.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// A human-readable string with the reason why the fulfillment order, or some of its line items, can't be
    /// moved to the location.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;

    /// <summary>
    /// Whether the fulfillment order can be moved to the location.
    /// </summary>
    [JsonPropertyName("movable")]
    public bool? movable { get; set; } = null;

    /// <summary>
    /// Fulfillment order line items that cannot be moved from their current location to the given location.
    /// </summary>
    [JsonPropertyName("unavailableLineItems")]
    public FulfillmentOrderLineItemConnection? unavailableLineItems { get; set; } = null;

    /// <summary>
    /// Total number of fulfillment order line items that can't be moved from their current assigned location to the
    /// given location.
    /// </summary>
    [JsonPropertyName("unavailableLineItemsCount")]
    public Count? unavailableLineItemsCount { get; set; } = null;
}