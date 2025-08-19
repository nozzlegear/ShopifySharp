#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `InventorySetQuantitiesUserError`.
/// </summary>
public enum InventorySetQuantitiesUserErrorCode
{
    INVALID_INVENTORY_ITEM,
    INVALID_LOCATION,
    INVALID_QUANTITY_NEGATIVE,
    INVALID_REASON,
    INVALID_REFERENCE_DOCUMENT,
    ITEM_NOT_STOCKED_AT_LOCATION,
    INVALID_QUANTITY_TOO_HIGH,
    INVALID_QUANTITY_TOO_LOW,
    COMPARE_QUANTITY_REQUIRED,
    COMPARE_QUANTITY_STALE,
    INVALID_NAME,
    NO_DUPLICATE_INVENTORY_ITEM_ID_GROUP_ID_PAIR,
    NON_MUTABLE_INVENTORY_ITEM,
}