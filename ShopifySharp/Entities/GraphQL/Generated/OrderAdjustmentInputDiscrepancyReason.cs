#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Discrepancy reasons for order adjustments.
/// </summary>
public enum OrderAdjustmentInputDiscrepancyReason
{
    RESTOCK,
    DAMAGE,
    CUSTOMER,
    OTHER,
}