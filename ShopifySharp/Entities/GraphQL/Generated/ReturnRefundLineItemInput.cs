#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a return refund line item.
/// </summary>
public record ReturnRefundLineItemInput : GraphQLInputObject<ReturnRefundLineItemInput>
{
    /// <summary>
    /// The quantity of the return line item to be refunded.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The ID of the return line item to be refunded.
    /// </summary>
    [JsonPropertyName("returnLineItemId")]
    public string? returnLineItemId { get; set; } = null;
}