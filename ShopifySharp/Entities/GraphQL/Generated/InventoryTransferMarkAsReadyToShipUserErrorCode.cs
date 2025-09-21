#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `InventoryTransferMarkAsReadyToShipUserError`.
/// </summary>
public enum InventoryTransferMarkAsReadyToShipUserErrorCode
{
    TRANSFER_NOT_FOUND,
    ITEMS_EMPTY,
    INVALID_TRANSFER_STATUS,
    INVALID_ITEM,
    LOCATION_NOT_ACTIVE,
    LOCATION_NOT_FOUND,
}