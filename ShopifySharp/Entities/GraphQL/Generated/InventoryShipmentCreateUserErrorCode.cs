#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `InventoryShipmentCreateUserError`.
/// </summary>
public enum InventoryShipmentCreateUserErrorCode
{
    EMPTY_SHIPMENT_INPUT,
    ITEM_NOT_FOUND,
    TRANSFER_NOT_FOUND,
    INVALID_TRANSFER_STATUS,
    BUNDLED_ITEM,
    INVALID_QUANTITY,
    UNTRACKED_ITEM,
    DUPLICATE_ITEM,
    INVALID_SHIPMENT_INPUT,
    INVALID_ITEM,
    INVALID_URL,
    LOCATION_NOT_ACTIVE,
}