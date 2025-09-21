#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a return.
/// </summary>
public record ReturnInput : GraphQLInputObject<ReturnInput>
{
    /// <summary>
    /// The new line items to be added to the order.
    /// </summary>
    [JsonPropertyName("exchangeLineItems")]
    public ICollection<ExchangeLineItemInput>? exchangeLineItems { get; set; } = null;

    /// <summary>
    /// The ID of the order to be returned.
    /// </summary>
    [JsonPropertyName("orderId")]
    public string? orderId { get; set; } = null;

    /// <summary>
    /// The UTC date and time when the return was first solicited by the customer.
    /// </summary>
    [JsonPropertyName("requestedAt")]
    public DateTime? requestedAt { get; set; } = null;

    /// <summary>
    /// The return line items list to be handled.
    /// </summary>
    [JsonPropertyName("returnLineItems")]
    public ICollection<ReturnLineItemInput>? returnLineItems { get; set; } = null;

    /// <summary>
    /// The return shipping fee to capture.
    /// </summary>
    [JsonPropertyName("returnShippingFee")]
    public ReturnShippingFeeInput? returnShippingFee { get; set; } = null;
}