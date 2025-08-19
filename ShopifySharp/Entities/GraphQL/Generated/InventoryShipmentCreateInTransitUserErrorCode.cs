#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `InventoryShipmentCreateInTransitUserError`.
/// </summary>
public enum InventoryShipmentCreateInTransitUserErrorCode
{
    DUPLICATE_ITEM,
    INVALID_QUANTITY,
    ITEM_NOT_FOUND,
    INVALID_TRANSFER_STATUS,
    UNTRACKED_ITEM,
    EMPTY_SHIPMENT_INPUT,
    ITEMS_EMPTY,
    TRANSFER_NOT_FOUND,
    INVALID_URL,
    INVALID_SHIPMENT_INPUT,
    INVALID_ITEM,
    INVENTORY_STATE_NOT_ACTIVE,
    LOCATION_NOT_ACTIVE,
}