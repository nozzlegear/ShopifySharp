#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `InventoryTransferSetItemsUserError`.
/// </summary>
public enum InventoryTransferSetItemsUserErrorCode
{
    TRANSFER_NOT_FOUND,
    INVALID_TRANSFER_STATUS,
    LOCATION_NOT_FOUND,
    BUNDLED_ITEM,
    UNTRACKED_ITEM,
    ITEM_NOT_FOUND,
    INVALID_QUANTITY,
    DUPLICATE_ITEM,
    INVENTORY_STATE_NOT_ACTIVE,
}