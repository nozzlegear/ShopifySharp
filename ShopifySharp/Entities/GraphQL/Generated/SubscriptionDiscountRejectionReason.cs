#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The reason a discount on a subscription draft was rejected.
/// </summary>
public enum SubscriptionDiscountRejectionReason
{
    NOT_FOUND,
    NO_ENTITLED_LINE_ITEMS,
    QUANTITY_NOT_IN_RANGE,
    PURCHASE_NOT_IN_RANGE,
    CUSTOMER_NOT_ELIGIBLE,
    USAGE_LIMIT_REACHED,
    CUSTOMER_USAGE_LIMIT_REACHED,
    CURRENTLY_INACTIVE,
    NO_ENTITLED_SHIPPING_LINES,
    INCOMPATIBLE_PURCHASE_TYPE,
    INTERNAL_ERROR,
}