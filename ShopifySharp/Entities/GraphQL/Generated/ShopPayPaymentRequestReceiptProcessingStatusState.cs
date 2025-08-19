#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The state of the payment request receipt.
/// </summary>
public enum ShopPayPaymentRequestReceiptProcessingStatusState
{
    READY,
    PROCESSING,
    FAILED,
    COMPLETED,
    ACTION_REQUIRED,
}