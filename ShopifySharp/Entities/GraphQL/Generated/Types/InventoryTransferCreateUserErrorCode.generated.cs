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
/// Possible error codes that can be returned by `InventoryTransferCreateUserError`.
/// </summary>
public enum InventoryTransferCreateUserErrorCode
{
    TRANSFER_NOT_FOUND,
    LOCATION_NOT_FOUND,
    LOCATION_NOT_ACTIVE,
    TRANSFER_ORIGIN_CANNOT_BE_THE_SAME_AS_DESTINATION,
    TAG_EXCEEDS_MAX_LENGTH,
    IDEMPOTENCY_CONCURRENT_REQUEST,
    IDEMPOTENCY_KEY_PARAMETER_MISMATCH,
    BUNDLED_ITEM,
    UNTRACKED_ITEM,
    ITEM_NOT_FOUND,
    INVALID_QUANTITY,
    DUPLICATE_ITEM,
    INVENTORY_STATE_NOT_ACTIVE,
}