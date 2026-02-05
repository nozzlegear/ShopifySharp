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
/// Possible error codes that can be returned by `InventoryShipmentUpdateItemQuantitiesUserError`.
/// </summary>
public enum InventoryShipmentUpdateItemQuantitiesUserErrorCode
{
    LOCATION_NOT_FOUND,
    SHIPMENT_NOT_FOUND,
    ITEM_NOT_FOUND,
    INVALID_QUANTITY,
    INVALID_SHIPMENT_STATUS,
    LOCATION_NOT_ACTIVE,
}