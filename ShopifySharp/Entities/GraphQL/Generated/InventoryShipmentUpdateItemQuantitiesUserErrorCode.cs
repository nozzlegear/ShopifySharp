#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `InventoryShipmentUpdateItemQuantitiesUserError`.
/// </summary>
public enum InventoryShipmentUpdateItemQuantitiesUserErrorCode
{
    SHIPMENT_NOT_FOUND,
    ITEM_NOT_FOUND,
    INVALID_QUANTITY,
    INVALID_SHIPMENT_STATUS,
    LOCATION_NOT_FOUND,
    LOCATION_NOT_ACTIVE,
}