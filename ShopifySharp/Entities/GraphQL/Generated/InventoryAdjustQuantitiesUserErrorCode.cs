#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `InventoryAdjustQuantitiesUserError`.
/// </summary>
public enum InventoryAdjustQuantitiesUserErrorCode
{
    INTERNAL_LEDGER_DOCUMENT,
    INVALID_AVAILABLE_DOCUMENT,
    INVALID_INVENTORY_ITEM,
    INVALID_LEDGER_DOCUMENT,
    INVALID_LOCATION,
    INVALID_QUANTITY_DOCUMENT,
    INVALID_QUANTITY_NAME,
    INVALID_QUANTITY_TOO_LOW,
    INVALID_QUANTITY_TOO_HIGH,
    INVALID_REASON,
    INVALID_REFERENCE_DOCUMENT,
    ADJUST_QUANTITIES_FAILED,
    MAX_ONE_LEDGER_DOCUMENT,
    ITEM_NOT_STOCKED_AT_LOCATION,
    NON_MUTABLE_INVENTORY_ITEM,
}