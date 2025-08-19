#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `FulfillmentOrderLineItemsPreparedForPickupUserError`.
/// </summary>
public enum FulfillmentOrderLineItemsPreparedForPickupUserErrorCode
{
    NO_LINE_ITEMS_TO_PREPARE_FOR_FULFILLMENT_ORDER,
    FULFILLMENT_ORDER_INVALID,
    UNABLE_TO_PREPARE_QUANTITY,
}