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
/// Possible error codes that can be returned by `InventoryShipmentCreateUserError`.
/// </summary>
public enum InventoryShipmentCreateUserErrorCode
{
    BARCODE_DUPLICATE,
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
    IDEMPOTENCY_CONCURRENT_REQUEST,
    IDEMPOTENCY_KEY_PARAMETER_MISMATCH,
}