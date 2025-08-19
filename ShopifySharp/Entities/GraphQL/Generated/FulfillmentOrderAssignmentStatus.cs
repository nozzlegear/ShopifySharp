#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The assigment status to be used to filter fulfillment orders.
/// </summary>
public enum FulfillmentOrderAssignmentStatus
{
    CANCELLATION_REQUESTED,
    FULFILLMENT_REQUESTED,
    FULFILLMENT_ACCEPTED,
    FULFILLMENT_UNSUBMITTED,
}