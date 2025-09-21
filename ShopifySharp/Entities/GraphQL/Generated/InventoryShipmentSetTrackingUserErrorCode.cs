#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `InventoryShipmentSetTrackingUserError`.
/// </summary>
public enum InventoryShipmentSetTrackingUserErrorCode
{
    SHIPMENT_NOT_FOUND,
    INVALID_URL,
}