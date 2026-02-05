#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for processing a return.
/// </summary>
public record ReturnProcessInput : GraphQLInputObject<ReturnProcessInput>
{
    /// <summary>
    /// The exchange line items list to be handled.
    /// </summary>
    [JsonPropertyName("exchangeLineItems")]
    public ICollection<ReturnProcessExchangeLineItemInput>? exchangeLineItems { get; set; } = null;

    /// <summary>
    /// The financial transfer for the return.
    /// </summary>
    [JsonPropertyName("financialTransfer")]
    public ReturnProcessFinancialTransferInput? financialTransfer { get; set; } = null;

    /// <summary>
    /// The note for the return.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// Whether to notify the customer about the return.
    /// </summary>
    [JsonPropertyName("notifyCustomer")]
    public bool? notifyCustomer { get; set; } = null;

    /// <summary>
    /// The refund duties list to be handled.
    /// </summary>
    [JsonPropertyName("refundDuties")]
    public ICollection<RefundDutyInput>? refundDuties { get; set; } = null;

    /// <summary>
    /// The shipping cost to refund.
    /// </summary>
    [JsonPropertyName("refundShipping")]
    public RefundShippingInput? refundShipping { get; set; } = null;

    /// <summary>
    /// The ID of the return to be processed.
    /// </summary>
    [JsonPropertyName("returnId")]
    public string? returnId { get; set; } = null;

    /// <summary>
    /// The return line items list to be handled.
    /// </summary>
    [JsonPropertyName("returnLineItems")]
    public ICollection<ReturnProcessReturnLineItemInput>? returnLineItems { get; set; } = null;

    /// <summary>
    /// ID of the tip line item.
    /// </summary>
    [JsonPropertyName("tipLineId")]
    public string? tipLineId { get; set; } = null;
}