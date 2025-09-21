#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `FulfillmentOrderMergeUserError`.
/// </summary>
public enum FulfillmentOrderMergeUserErrorCode
{
    FULFILLMENT_ORDER_NOT_FOUND,
    GREATER_THAN,
    INVALID_LINE_ITEM_QUANTITY,
}