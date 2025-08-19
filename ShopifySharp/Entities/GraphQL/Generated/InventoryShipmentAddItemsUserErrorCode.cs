#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `InventoryShipmentAddItemsUserError`.
/// </summary>
public enum InventoryShipmentAddItemsUserErrorCode
{
    INVALID_SHIPMENT_STATUS,
    DUPLICATE_ITEM,
    INVALID_QUANTITY,
    ITEM_NOT_FOUND,
    UNTRACKED_ITEM,
    SHIPMENT_NOT_FOUND,
    LOCATION_NOT_FOUND,
    LOCATION_NOT_ACTIVE,
}