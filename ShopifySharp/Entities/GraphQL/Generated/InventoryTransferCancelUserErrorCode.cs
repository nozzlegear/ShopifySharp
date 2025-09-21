#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `InventoryTransferCancelUserError`.
/// </summary>
public enum InventoryTransferCancelUserErrorCode
{
    TRANSFER_NOT_FOUND,
    INVALID_TRANSFER_STATUS,
    SHIPMENT_EXISTS,
}