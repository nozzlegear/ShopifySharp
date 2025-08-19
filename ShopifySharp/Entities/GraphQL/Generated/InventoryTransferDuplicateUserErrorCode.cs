#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `InventoryTransferDuplicateUserError`.
/// </summary>
public enum InventoryTransferDuplicateUserErrorCode
{
    TRANSFER_NOT_FOUND,
}