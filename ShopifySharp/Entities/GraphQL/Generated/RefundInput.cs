#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to create a refund.
/// </summary>
public record RefundInput : GraphQLInputObject<RefundInput>
{
    /// <summary>
    /// Whether to allow the total refunded amount to surpass the amount paid for the order.
    /// </summary>
    [JsonPropertyName("allowOverRefunding")]
    public bool? allowOverRefunding { get; set; } = null;

    /// <summary>
    /// The currency that is used to refund the order. This must be the presentment
    /// currency, which is the currency used by the customer. This is a required field
    /// for orders where the currency and presentment currency differ.
    /// </summary>
    [JsonPropertyName("currency")]
    public CurrencyCode? currency { get; set; } = null;

    /// <summary>
    /// An optional reason for a discrepancy between calculated and actual refund amounts.
    /// </summary>
    [JsonPropertyName("discrepancyReason")]
    public OrderAdjustmentInputDiscrepancyReason? discrepancyReason { get; set; } = null;

    /// <summary>
    /// An optional note that's attached to the refund.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// Whether to send a refund notification to the customer.
    /// </summary>
    [JsonPropertyName("notify")]
    public bool? notify { get; set; } = null;

    /// <summary>
    /// The ID of the order that's being refunded.
    /// </summary>
    [JsonPropertyName("orderId")]
    public string? orderId { get; set; } = null;

    /// <summary>
    /// A list of duties to refund.
    /// </summary>
    [JsonPropertyName("refundDuties")]
    public ICollection<RefundDutyInput>? refundDuties { get; set; } = null;

    /// <summary>
    /// A list of line items to refund.
    /// </summary>
    [JsonPropertyName("refundLineItems")]
    public ICollection<RefundLineItemInput>? refundLineItems { get; set; } = null;

    /// <summary>
    /// A list of instructions to process the financial outcome of the refund.
    /// </summary>
    [JsonPropertyName("refundMethods")]
    public ICollection<RefundMethodInput>? refundMethods { get; set; } = null;

    /// <summary>
    /// The input fields that are required to reimburse shipping costs.
    /// </summary>
    [JsonPropertyName("shipping")]
    public ShippingRefundInput? shipping { get; set; } = null;

    /// <summary>
    /// A list of transactions involved in the refund.
    /// </summary>
    [JsonPropertyName("transactions")]
    public ICollection<OrderTransactionInput>? transactions { get; set; } = null;
}