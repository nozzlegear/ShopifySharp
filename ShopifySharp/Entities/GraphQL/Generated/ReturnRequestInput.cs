#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for requesting a return.
/// </summary>
public record ReturnRequestInput : GraphQLInputObject<ReturnRequestInput>
{
    /// <summary>
    /// The ID of the order that's being returned.
    /// </summary>
    [JsonPropertyName("orderId")]
    public string? orderId { get; set; } = null;

    /// <summary>
    /// The line items that are being handled in the return.
    /// </summary>
    [JsonPropertyName("returnLineItems")]
    public ICollection<ReturnRequestLineItemInput>? returnLineItems { get; set; } = null;

    /// <summary>
    /// The return shipping fee to capture.
    /// </summary>
    [JsonPropertyName("returnShippingFee")]
    public ReturnShippingFeeInput? returnShippingFee { get; set; } = null;
}