#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The possible source types for a balance transaction.
/// </summary>
public enum ShopifyPaymentsSourceType
{
    ADJUSTMENT_REVERSAL,
    CHARGE,
    REFUND,
    SYSTEM_ADJUSTMENT,
    DISPUTE,
    ADJUSTMENT,
    TRANSFER,
}