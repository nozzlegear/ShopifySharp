#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `InventoryBulkToggleActivationUserError`.
/// </summary>
public enum InventoryBulkToggleActivationUserErrorCode
{
    GENERIC_ERROR,
    CANNOT_DEACTIVATE_FROM_ONLY_LOCATION,
    [Obsolete("This error code is deprecated. Both INCOMING_INVENTORY_AT_LOCATION and COMMITTED_INVENTORY_AT_LOCATION codes will be returned as individual errors instead.")]
    COMMITTED_AND_INCOMING_INVENTORY_AT_LOCATION,
    INCOMING_INVENTORY_AT_LOCATION,
    COMMITTED_INVENTORY_AT_LOCATION,
    RESERVED_INVENTORY_AT_LOCATION,
    FAILED_TO_UNSTOCK_FROM_LOCATION,
    INVENTORY_MANAGED_BY_3RD_PARTY,
    INVENTORY_MANAGED_BY_SHOPIFY,
    FAILED_TO_STOCK_AT_LOCATION,
    MISSING_SKU,
    LOCATION_NOT_FOUND,
    INVENTORY_ITEM_NOT_FOUND,
}