#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The actions that can be taken on a fulfillment order.
/// </summary>
public enum FulfillmentOrderAction
{
    CREATE_FULFILLMENT,
    REQUEST_FULFILLMENT,
    CANCEL_FULFILLMENT_ORDER,
    MOVE,
    REQUEST_CANCELLATION,
    MARK_AS_OPEN,
    RELEASE_HOLD,
    HOLD,
    EXTERNAL,
    SPLIT,
    MERGE,
}