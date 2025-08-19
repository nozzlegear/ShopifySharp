#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `InventoryShipmentRemoveItemsUserError`.
/// </summary>
public enum InventoryShipmentRemoveItemsUserErrorCode
{
    INTERNAL_ERROR,
    SHIPMENT_NOT_FOUND,
    ITEM_NOT_FOUND,
    INVALID_SHIPMENT_STATUS,
    LOCATION_NOT_FOUND,
}