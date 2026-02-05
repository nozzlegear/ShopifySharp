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
/// The reason for receiving a line item on an inventory shipment.
/// </summary>
public enum InventoryShipmentReceiveLineItemReason
{
    ACCEPTED,
    REJECTED,
}