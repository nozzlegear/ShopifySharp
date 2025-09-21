#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Discrepancy reasons for order adjustments.
/// </summary>
public enum OrderAdjustmentDiscrepancyReason
{
    RESTOCK,
    DAMAGE,
    CUSTOMER,
    REFUND_DISCREPANCY,
    FULL_RETURN_BALANCING_ADJUSTMENT,
    PENDING_REFUND_DISCREPANCY,
}