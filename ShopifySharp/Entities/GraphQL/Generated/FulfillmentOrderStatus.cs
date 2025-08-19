#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The status of a fulfillment order.
/// </summary>
public enum FulfillmentOrderStatus
{
    OPEN,
    IN_PROGRESS,
    CANCELLED,
    INCOMPLETE,
    CLOSED,
    SCHEDULED,
    ON_HOLD,
}