#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `InventorySetOnHandQuantitiesUserError`.
/// </summary>
public enum InventorySetOnHandQuantitiesUserErrorCode
{
    INVALID_INVENTORY_ITEM,
    INVALID_LOCATION,
    INVALID_QUANTITY_NEGATIVE,
    INVALID_REASON,
    INVALID_REFERENCE_DOCUMENT,
    SET_ON_HAND_QUANTITIES_FAILED,
    ITEM_NOT_STOCKED_AT_LOCATION,
    NON_MUTABLE_INVENTORY_ITEM,
    INVALID_QUANTITY_TOO_HIGH,
}