#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to calculate return amounts associated with an order.
/// </summary>
public record CalculateReturnInput : GraphQLInputObject<CalculateReturnInput>
{
    /// <summary>
    /// The exchange line items to add to the order.
    /// </summary>
    [JsonPropertyName("exchangeLineItems")]
    public ICollection<CalculateExchangeLineItemInput>? exchangeLineItems { get; set; } = null;

    /// <summary>
    /// The ID of the order that will be returned.
    /// </summary>
    [JsonPropertyName("orderId")]
    public string? orderId { get; set; } = null;

    /// <summary>
    /// The line items from the order to include in the return.
    /// </summary>
    [JsonPropertyName("returnLineItems")]
    public ICollection<CalculateReturnLineItemInput>? returnLineItems { get; set; } = null;

    /// <summary>
    /// The return shipping fee associated with the return.
    /// </summary>
    [JsonPropertyName("returnShippingFee")]
    public ReturnShippingFeeInput? returnShippingFee { get; set; } = null;
}