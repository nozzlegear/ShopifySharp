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