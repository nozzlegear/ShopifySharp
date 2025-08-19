#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record ReturnOutcomeFinancialTransferInvoiceReturnOutcome(InvoiceReturnOutcome Value): ReturnOutcomeFinancialTransfer;
internal record ReturnOutcomeFinancialTransferRefundReturnOutcome(RefundReturnOutcome Value): ReturnOutcomeFinancialTransfer;
#endif /// <summary>

/// The input fields for an exchange line item.
/// </summary>
public record ReturnProcessExchangeLineItemInput : GraphQLInputObject<ReturnProcessExchangeLineItemInput>
{
    /// <summary>
    /// The ID of the exchange line item.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The quantity of the exchange line item.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;
}