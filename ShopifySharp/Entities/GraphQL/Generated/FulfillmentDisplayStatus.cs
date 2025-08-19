#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The display status of a fulfillment.
/// </summary>
public enum FulfillmentDisplayStatus
{
    ATTEMPTED_DELIVERY,
    CANCELED,
    CONFIRMED,
    DELAYED,
    DELIVERED,
    FAILURE,
    FULFILLED,
    IN_TRANSIT,
    LABEL_PRINTED,
    LABEL_PURCHASED,
    LABEL_VOIDED,
    MARKED_AS_FULFILLED,
    NOT_DELIVERED,
    OUT_FOR_DELIVERY,
    READY_FOR_PICKUP,
    PICKED_UP,
    SUBMITTED,
}