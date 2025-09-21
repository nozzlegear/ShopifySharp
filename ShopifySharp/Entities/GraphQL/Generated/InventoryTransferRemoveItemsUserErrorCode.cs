#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `InventoryTransferRemoveItemsUserError`.
/// </summary>
public enum InventoryTransferRemoveItemsUserErrorCode
{
    TRANSFER_NOT_FOUND,
    CANT_REMOVE_ALL_ITEMS_FROM_READY_TO_SHIP_TRANSFER,
    ITEM_NOT_FOUND,
    ALL_QUANTITY_SHIPPED,
    ITEM_PRESENT_ON_DRAFT_SHIPMENT_WITH_ZERO_QUANTITY,
    INVALID_TRANSFER_STATUS,
    LOCATION_NOT_FOUND,
}