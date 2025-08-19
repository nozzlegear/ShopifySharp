#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for return line items on a calculated return.
/// </summary>
public record CalculateReturnLineItemInput : GraphQLInputObject<CalculateReturnLineItemInput>
{
    /// <summary>
    /// The ID of the fulfillment line item to be returned.
    /// </summary>
    [JsonPropertyName("fulfillmentLineItemId")]
    public string? fulfillmentLineItemId { get; set; } = null;

    /// <summary>
    /// The quantity of the item to be returned.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The restocking fee for the return line item.
    /// </summary>
    [JsonPropertyName("restockingFee")]
    public RestockingFeeInput? restockingFee { get; set; } = null;
}