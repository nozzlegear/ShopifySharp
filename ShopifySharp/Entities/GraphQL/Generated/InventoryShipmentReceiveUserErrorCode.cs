#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `InventoryShipmentReceiveUserError`.
/// </summary>
public enum InventoryShipmentReceiveUserErrorCode
{
    INTERNAL_ERROR,
    INVALID_SHIPMENT_STATUS,
    INVENTORY_STATE_NOT_ACTIVE,
    SHIPMENT_NOT_FOUND,
    INVALID_QUANTITY,
    ITEM_NOT_FOUND,
    LOCATION_NOT_ACTIVE,
    LOCATION_NOT_FOUND,
}