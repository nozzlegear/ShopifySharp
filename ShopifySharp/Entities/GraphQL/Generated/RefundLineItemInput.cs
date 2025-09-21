#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to reimburse line items on a refund.
/// </summary>
public record RefundLineItemInput : GraphQLInputObject<RefundLineItemInput>
{
    /// <summary>
    /// The ID of the line item in the refund.
    /// </summary>
    [JsonPropertyName("lineItemId")]
    public string? lineItemId { get; set; } = null;

    /// <summary>
    /// The intended location for restocking. If the `restockType` is set to `NO_RESTOCK`, then this value is empty.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? locationId { get; set; } = null;

    /// <summary>
    /// The quantity of the associated line item to be refunded.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The type of restock for this line item.
    /// </summary>
    [JsonPropertyName("restockType")]
    public RefundLineItemRestockType? restockType { get; set; } = null;
}