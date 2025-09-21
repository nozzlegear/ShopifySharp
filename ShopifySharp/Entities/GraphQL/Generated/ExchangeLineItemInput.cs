#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for new line items to be added to the order as part of an exchange.
/// </summary>
public record ExchangeLineItemInput : GraphQLInputObject<ExchangeLineItemInput>
{
    /// <summary>
    /// The discount to be applied to the exchange line item.
    /// </summary>
    [JsonPropertyName("appliedDiscount")]
    public ExchangeLineItemAppliedDiscountInput? appliedDiscount { get; set; } = null;

    /// <summary>
    /// The gift card codes associated with the physical gift cards.
    /// </summary>
    [JsonPropertyName("giftCardCodes")]
    public ICollection<string>? giftCardCodes { get; set; } = null;

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