#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `InventoryTransferDeleteUserError`.
/// </summary>
public enum InventoryTransferDeleteUserErrorCode
{
    TRANSFER_NOT_FOUND,
    INVALID_TRANSFER_STATUS,
}