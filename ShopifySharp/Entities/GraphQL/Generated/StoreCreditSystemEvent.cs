#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The event that caused the store credit account transaction.
/// </summary>
public enum StoreCreditSystemEvent
{
    ADJUSTMENT,
    ORDER_PAYMENT,
    ORDER_REFUND,
    PAYMENT_FAILURE,
    PAYMENT_RETURNED,
    ORDER_CANCELLATION,
    TAX_FINALIZATION,
}