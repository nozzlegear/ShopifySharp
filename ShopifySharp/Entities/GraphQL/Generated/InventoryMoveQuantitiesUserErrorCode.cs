#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `InventoryMoveQuantitiesUserError`.
/// </summary>
public enum InventoryMoveQuantitiesUserErrorCode
{
    INTERNAL_LEDGER_DOCUMENT,
    INVALID_AVAILABLE_DOCUMENT,
    INVALID_INVENTORY_ITEM,
    INVALID_LEDGER_DOCUMENT,
    INVALID_LOCATION,
    INVALID_QUANTITY_DOCUMENT,
    INVALID_QUANTITY_NAME,
    INVALID_QUANTITY_NEGATIVE,
    INVALID_QUANTITY_TOO_HIGH,
    INVALID_REASON,
    INVALID_REFERENCE_DOCUMENT,
    MOVE_QUANTITIES_FAILED,
    DIFFERENT_LOCATIONS,
    SAME_QUANTITY_NAME,
    MAXIMUM_LEDGER_DOCUMENT_URIS,
    ITEM_NOT_STOCKED_AT_LOCATION,
    NON_MUTABLE_INVENTORY_ITEM,
}