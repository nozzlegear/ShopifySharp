#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `InventorySetScheduledChangesUserError`.
/// </summary>
public enum InventorySetScheduledChangesUserErrorCode
{
    ERROR_UPDATING_SCHEDULED,
    SAME_FROM_TO_NAMES,
    INVALID_FROM_NAME,
    INVALID_TO_NAME,
    DUPLICATE_TO_NAME,
    INVALID_REASON,
    DUPLICATE_FROM_NAME,
    LOCATION_NOT_FOUND,
    INVENTORY_STATE_NOT_FOUND,
    ITEMS_EMPTY,
    INVENTORY_ITEM_NOT_FOUND,
    INCLUSION,
    LEDGER_DOCUMENT_INVALID,
}