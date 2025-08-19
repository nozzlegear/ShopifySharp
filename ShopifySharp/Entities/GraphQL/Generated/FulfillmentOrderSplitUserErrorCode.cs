#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `FulfillmentOrderSplitUserError`.
/// </summary>
public enum FulfillmentOrderSplitUserErrorCode
{
    FULFILLMENT_ORDER_NOT_FOUND,
    GREATER_THAN,
    INVALID_LINE_ITEM_QUANTITY,
    NO_LINE_ITEMS_PROVIDED_TO_SPLIT,
}