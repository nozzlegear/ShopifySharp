#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a return line item.
/// </summary>
public record ReturnRequestLineItemInput : GraphQLInputObject<ReturnRequestLineItemInput>
{
    /// <summary>
    /// A note from the customer that describes the item to be returned.
    /// For example, the note can communicate issues with the item to the merchant.
    /// Maximum length: 300 characters.
    /// </summary>
    [JsonPropertyName("customerNote")]
    public string? customerNote { get; set; } = null;

    /// <summary>
    /// The ID of the fulfillment line item to be returned.
    /// Specifically, this field expects a `FulfillmentLineItem.id`.
    /// </summary>
    [JsonPropertyName("fulfillmentLineItemId")]
    public string? fulfillmentLineItemId { get; set; } = null;

    /// <summary>
    /// The quantity of the item that's being returned.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The restocking fee to capture.
    /// </summary>
    [JsonPropertyName("restockingFee")]
    public RestockingFeeInput? restockingFee { get; set; } = null;

    /// <summary>
    /// The reason why the line item is being returned.
    /// </summary>
    [JsonPropertyName("returnReason")]
    public ReturnReason? returnReason { get; set; } = null;
}