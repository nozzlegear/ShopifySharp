#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The set of valid sort keys for the Payout query.
/// </summary>
public enum PayoutSortKeys
{
    ADJUSTMENT_GROSS,
    ADVANCE_GROSS,
    AMOUNT,
    CHARGE_GROSS,
    DUTIES_GROSS,
    FEE_AMOUNT,
    ID,
    ISSUED_AT,
    REFUND_GROSS,
    SHIPPING_LABEL_GROSS,
    STATUS,
}