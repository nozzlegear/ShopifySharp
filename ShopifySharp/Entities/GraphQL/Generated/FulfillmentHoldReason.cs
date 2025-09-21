#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The reason for a fulfillment hold.
/// </summary>
public enum FulfillmentHoldReason
{
    AWAITING_PAYMENT,
    HIGH_RISK_OF_FRAUD,
    INCORRECT_ADDRESS,
    INVENTORY_OUT_OF_STOCK,
    UNKNOWN_DELIVERY_DATE,
    ONLINE_STORE_POST_PURCHASE_CROSS_SELL,
    AWAITING_RETURN_ITEMS,
    OTHER,
}