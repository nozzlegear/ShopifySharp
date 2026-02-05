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
/// Possible error codes that can be returned by `InventorySetOnHandQuantitiesUserError`.
/// </summary>
public enum InventorySetOnHandQuantitiesUserErrorCode
{
    INVALID_INVENTORY_ITEM,
    INVALID_LOCATION,
    INVALID_QUANTITY_NEGATIVE,
    INVALID_REASON,
    INVALID_REFERENCE_DOCUMENT,
    CHANGE_FROM_QUANTITY_STALE,
    SET_ON_HAND_QUANTITIES_FAILED,
    ITEM_NOT_STOCKED_AT_LOCATION,
    NON_MUTABLE_INVENTORY_ITEM,
    INVALID_QUANTITY_TOO_HIGH,
    COMPARE_QUANTITY_STALE,
    SERVICE_UNAVAILABLE,
    IDEMPOTENCY_CONCURRENT_REQUEST,
    IDEMPOTENCY_KEY_PARAMETER_MISMATCH,
}