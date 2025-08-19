#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to refund a return.
/// </summary>
public record ReturnRefundInput : GraphQLInputObject<ReturnRefundInput>
{
    /// <summary>
    /// Whether to send a refund notification to the customer.
    /// </summary>
    [JsonPropertyName("notifyCustomer")]
    public bool? notifyCustomer { get; set; } = null;

    /// <summary>
    /// A list of transactions involved in refunding the return.
    /// </summary>
    [JsonPropertyName("orderTransactions")]
    public ICollection<ReturnRefundOrderTransactionInput>? orderTransactions { get; set; } = null;

    /// <summary>
    /// A list of duties to refund.
    /// </summary>
    [JsonPropertyName("refundDuties")]
    public ICollection<RefundDutyInput>? refundDuties { get; set; } = null;

    /// <summary>
    /// The shipping amount to refund.
    /// </summary>
    [JsonPropertyName("refundShipping")]
    public RefundShippingInput? refundShipping { get; set; } = null;

    /// <summary>
    /// The ID of the return.
    /// </summary>
    [JsonPropertyName("returnId")]
    public string? returnId { get; set; } = null;

    /// <summary>
    /// A list of return line items to refund.
    /// </summary>
    [JsonPropertyName("returnRefundLineItems")]
    public ICollection<ReturnRefundLineItemInput>? returnRefundLineItems { get; set; } = null;
}