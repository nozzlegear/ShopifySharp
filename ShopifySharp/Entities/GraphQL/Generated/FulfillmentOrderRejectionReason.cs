#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The reason for a fulfillment order rejection.
/// </summary>
public enum FulfillmentOrderRejectionReason
{
    INCORRECT_ADDRESS,
    INVENTORY_OUT_OF_STOCK,
    INELIGIBLE_PRODUCT,
    UNDELIVERABLE_DESTINATION,
    INTERNATIONAL_SHIPPING_UNAVAILABLE,
    INCORRECT_PRODUCT_INFO,
    MISSING_CUSTOMS_INFO,
    INVALID_SKU,
    PAYMENT_DECLINED,
    PACKAGE_PREFERENCE_NOT_SET,
    INVALID_CONTACT_INFORMATION,
    ORDER_TOO_LARGE,
    MERCHANT_BLOCKED_OR_SUSPENDED,
    OTHER,
}