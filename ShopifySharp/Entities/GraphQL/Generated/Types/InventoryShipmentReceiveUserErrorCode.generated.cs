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
/// Possible error codes that can be returned by `InventoryShipmentReceiveUserError`.
/// </summary>
public enum InventoryShipmentReceiveUserErrorCode
{
    LOCATION_NOT_FOUND,
    IDEMPOTENCY_CONCURRENT_REQUEST,
    IDEMPOTENCY_KEY_PARAMETER_MISMATCH,
    INTERNAL_ERROR,
    INVALID_SHIPMENT_STATUS,
    INVENTORY_STATE_NOT_ACTIVE,
    SHIPMENT_NOT_FOUND,
    INVALID_QUANTITY,
    ITEM_NOT_FOUND,
    LOCATION_NOT_ACTIVE,
}