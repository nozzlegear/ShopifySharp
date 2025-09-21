#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The reason for receiving a line item on an inventory shipment.
/// </summary>
public enum InventoryShipmentReceiveLineItemReason
{
    ACCEPTED,
    REJECTED,
}