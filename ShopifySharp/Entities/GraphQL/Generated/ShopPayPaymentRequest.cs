#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a Shop Pay payment request.
/// </summary>
public record ShopPayPaymentRequest : IGraphQLObject
{
    /// <summary>
    /// The discounts for the payment request order.
    /// </summary>
    [JsonPropertyName("discounts")]
    public ICollection<ShopPayPaymentRequestDiscount>? discounts { get; set; } = null;

    /// <summary>
    /// The line items for the payment request.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public ICollection<ShopPayPaymentRequestLineItem>? lineItems { get; set; } = null;

    /// <summary>
    /// The presentment currency for the payment request.
    /// </summary>
    [JsonPropertyName("presentmentCurrency")]
    public CurrencyCode? presentmentCurrency { get; set; } = null;

    /// <summary>
    /// The delivery method type for the payment request.
    /// </summary>
    [JsonPropertyName("selectedDeliveryMethodType")]
    public ShopPayPaymentRequestDeliveryMethodType? selectedDeliveryMethodType { get; set; } = null;

    /// <summary>
    /// The shipping address for the payment request.
    /// </summary>
    [JsonPropertyName("shippingAddress")]
    public ShopPayPaymentRequestContactField? shippingAddress { get; set; } = null;

    /// <summary>
    /// The shipping lines for the payment request.
    /// </summary>
    [JsonPropertyName("shippingLines")]
    public ICollection<ShopPayPaymentRequestShippingLine>? shippingLines { get; set; } = null;

    /// <summary>
    /// The subtotal amount for the payment request.
    /// </summary>
    [JsonPropertyName("subtotal")]
    public MoneyV2? subtotal { get; set; } = null;

    /// <summary>
    /// The total amount for the payment request.
    /// </summary>
    [JsonPropertyName("total")]
    public MoneyV2? total { get; set; } = null;

    /// <summary>
    /// The total shipping price for the payment request.
    /// </summary>
    [JsonPropertyName("totalShippingPrice")]
    public ShopPayPaymentRequestTotalShippingPrice? totalShippingPrice { get; set; } = null;

    /// <summary>
    /// The total tax for the payment request.
    /// </summary>
    [JsonPropertyName("totalTax")]
    public MoneyV2? totalTax { get; set; } = null;
}