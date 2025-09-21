#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents the order's aggregated fulfillment status for display purposes.
/// </summary>
public enum OrderDisplayFulfillmentStatus
{
    UNFULFILLED,
    PARTIALLY_FULFILLED,
    FULFILLED,
    RESTOCKED,
    PENDING_FULFILLMENT,
    OPEN,
    IN_PROGRESS,
    ON_HOLD,
    SCHEDULED,
    REQUEST_DECLINED,
}