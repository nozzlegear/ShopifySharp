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
/// Possible error codes that can be returned by `FulfillmentOrdersRerouteUserError`.
/// </summary>
public enum FulfillmentOrdersRerouteUserErrorCode
{
    NO_FULFILLMENT_ORDER_IDS,
    FULFILLMENT_ORDER_NOT_FOUND,
    FULFILLMENT_ORDERS_NOT_FROM_THE_SAME_ORDER,
    FULFILLMENT_ORDERS_STATE_NOT_SUPPORTED,
    CANNOT_REASSIGN_LOCATION_FOR_FULFILLMENT_ORDERS,
    DELIVERY_METHOD_TYPE_NOT_SUPPORTED,
    SINGLE_LOCATION_SHOP_NOT_SUPPORTED,
    FULFILLMENT_ORDERS_MUST_BELONG_TO_SAME_LOCATION,
    CANNOT_MOVE_FULFILLMENT_ORDER_WITH_REPORTED_PROGRESS,
}