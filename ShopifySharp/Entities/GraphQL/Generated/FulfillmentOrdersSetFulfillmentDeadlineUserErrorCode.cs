#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `FulfillmentOrdersSetFulfillmentDeadlineUserError`.
/// </summary>
public enum FulfillmentOrdersSetFulfillmentDeadlineUserErrorCode
{
    FULFILLMENT_ORDERS_NOT_FOUND,
}