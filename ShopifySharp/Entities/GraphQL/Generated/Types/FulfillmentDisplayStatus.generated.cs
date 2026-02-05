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
    CARRIER_PICKED_UP,
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