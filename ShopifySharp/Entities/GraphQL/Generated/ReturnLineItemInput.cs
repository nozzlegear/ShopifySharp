#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a return line item.
/// </summary>
public record ReturnLineItemInput : GraphQLInputObject<ReturnLineItemInput>
{
    /// <summary>
    /// The ID of the fulfillment line item to be returned.
    /// Specifically, this field expects a `FulfillmentLineItem.id`.
    /// </summary>
    [JsonPropertyName("fulfillmentLineItemId")]
    public string? fulfillmentLineItemId { get; set; } = null;

    /// <summary>
    /// The quantity of the item to be returned.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The restocking fee to capture.
    /// </summary>
    [JsonPropertyName("restockingFee")]
    public RestockingFeeInput? restockingFee { get; set; } = null;

    /// <summary>
    /// The reason for the item to be returned.
    /// </summary>
    [JsonPropertyName("returnReason")]
    public ReturnReason? returnReason { get; set; } = null;

    /// <summary>
    /// A note about the reason that the item is being returned.
    /// Maximum length: 255 characters.
    /// </summary>
    [JsonPropertyName("returnReasonNote")]
    public string? returnReasonNote { get; set; } = null;
}