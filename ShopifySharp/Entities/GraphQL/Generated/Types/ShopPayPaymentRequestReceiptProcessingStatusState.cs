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