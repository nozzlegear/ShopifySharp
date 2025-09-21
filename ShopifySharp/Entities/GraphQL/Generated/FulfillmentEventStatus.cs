#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The status that describes a fulfillment or delivery event.
/// </summary>
public enum FulfillmentEventStatus
{
    LABEL_PURCHASED,
    LABEL_PRINTED,
    READY_FOR_PICKUP,
    CONFIRMED,
    IN_TRANSIT,
    OUT_FOR_DELIVERY,
    ATTEMPTED_DELIVERY,
    DELAYED,
    DELIVERED,
    FAILURE,
}