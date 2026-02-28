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
/// Possible error codes that can be returned by `InventoryTransferCreateAsReadyToShipUserError`.
/// </summary>
public enum InventoryTransferCreateAsReadyToShipUserErrorCode
{
    TRANSFER_NOT_FOUND,
    ITEMS_EMPTY,
    INVALID_TRANSFER_STATUS,
    LOCATION_NOT_ACTIVE,
    LOCATION_NOT_FOUND,
    TRANSFER_ORIGIN_CANNOT_BE_THE_SAME_AS_DESTINATION,
    TAG_EXCEEDS_MAX_LENGTH,
    LOCATION_REQUIRED,
    IDEMPOTENCY_CONCURRENT_REQUEST,
    IDEMPOTENCY_KEY_PARAMETER_MISMATCH,
    BUNDLED_ITEM,
    UNTRACKED_ITEM,
    ITEM_NOT_FOUND,
    INVALID_QUANTITY,
    DUPLICATE_ITEM,
    INVENTORY_STATE_NOT_ACTIVE,
}