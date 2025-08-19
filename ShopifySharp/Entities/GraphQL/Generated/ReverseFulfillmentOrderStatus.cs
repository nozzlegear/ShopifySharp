#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The status of a reverse fulfillment order.
/// </summary>
public enum ReverseFulfillmentOrderStatus
{
    CANCELED,
    CLOSED,
    OPEN,
}