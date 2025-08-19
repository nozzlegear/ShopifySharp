#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for exchange line items on a calculated return.
/// </summary>
public record CalculateExchangeLineItemInput : GraphQLInputObject<CalculateExchangeLineItemInput>
{
    /// <summary>
    /// The discount to be applied to the exchange line item.
    /// </summary>
    [JsonPropertyName("appliedDiscount")]
    public ExchangeLineItemAppliedDiscountInput? appliedDiscount { get; set; } = null;

    /// <summary>
    /// The quantity of the item to be added.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The ID of the product variant to be added to the order as part of an exchange.
    /// </summary>
    [JsonPropertyName("variantId")]
    public string? variantId { get; set; } = null;
}