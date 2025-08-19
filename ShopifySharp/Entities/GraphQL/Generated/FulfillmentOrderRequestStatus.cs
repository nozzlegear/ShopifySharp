#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The request status of a fulfillment order.
/// </summary>
public enum FulfillmentOrderRequestStatus
{
    UNSUBMITTED,
    SUBMITTED,
    ACCEPTED,
    REJECTED,
    CANCELLATION_REQUESTED,
    CANCELLATION_ACCEPTED,
    CANCELLATION_REJECTED,
    CLOSED,
}