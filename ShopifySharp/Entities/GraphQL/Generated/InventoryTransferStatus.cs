#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The status of a transfer.
/// </summary>
public enum InventoryTransferStatus
{
    DRAFT,
    READY_TO_SHIP,
    IN_PROGRESS,
    TRANSFERRED,
    CANCELED,
    OTHER,
}