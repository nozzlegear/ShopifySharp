#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `InventoryShipmentAddItemsUserError`.
/// </summary>
public enum InventoryShipmentAddItemsUserErrorCode
{
    LOCATION_NOT_FOUND,
    INVALID_SHIPMENT_STATUS,
    DUPLICATE_ITEM,
    INVALID_QUANTITY,
    ITEM_NOT_FOUND,
    INVENTORY_STATE_NOT_ACTIVE,
    UNTRACKED_ITEM,
    SHIPMENT_NOT_FOUND,
    LOCATION_NOT_ACTIVE,
    ACTIVATION_FAILED,
    IDEMPOTENCY_CONCURRENT_REQUEST,
    IDEMPOTENCY_KEY_PARAMETER_MISMATCH,
}