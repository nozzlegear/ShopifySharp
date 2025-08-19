#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `FulfillmentOrderRescheduleUserError`.
/// </summary>
public enum FulfillmentOrderRescheduleUserErrorCode
{
    FULFILLMENT_ORDER_NOT_FOUND,
}