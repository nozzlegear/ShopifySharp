#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The status of an inventory shipment.
/// </summary>
public enum InventoryShipmentStatus
{
    DRAFT,
    IN_TRANSIT,
    PARTIALLY_RECEIVED,
    RECEIVED,
    OTHER,
}