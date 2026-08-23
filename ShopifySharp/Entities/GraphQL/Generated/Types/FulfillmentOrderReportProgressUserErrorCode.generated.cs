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
/// Possible error codes that can be returned by `FulfillmentOrderReportProgressUserError`.
/// </summary>
public enum FulfillmentOrderReportProgressUserErrorCode
{
    FULFILLMENT_ORDER_NOT_FOUND,
    FULFILLMENT_ORDER_STATUS_INVALID,
    FULFILLMENT_ORDER_CONTAINS_PICKED_ITEMS,
    FULFILLMENT_ORDER_INVALID_DELIVERY_METHOD,
    FULFILLMENT_ORDER_INVALID_FULFILLMENT_SERVICE_OWNERSHIP,
    FULFILLMENT_ORDER_UNSUPPORTED_ACTION,
    MARKETPLACE_APP_NOT_ELIGIBLE,
}