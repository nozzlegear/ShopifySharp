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
/// Possible error codes that can be returned by `ShippingLabelPurchaseUserError`.
/// </summary>
public enum ShippingLabelPurchaseUserErrorCode
{
    NOT_FOUND,
    TOTAL_WEIGHT_ZERO,
    SHIPPING_DATE_IN_THE_PAST,
    MISSING_SHIPPING_RATE,
    MISSING_SHIPPING_DATE,
    MISSING_INSURANCE_COVERAGE_AMOUNT,
    MISSING_INSURANCE_COVERAGE_CURRENCY,
    INVALID_PACKAGE_DIMENSIONS,
    MISSING_HS_CODE,
    MISSING_COUNTRY_OF_ORIGIN,
    AT_LEAST_1_ITEM_REQUIRED,
    PHONE_NUMBER_NOT_FULLY_QUALIFIED_ORIGIN,
    PHONE_NUMBER_NOT_FULLY_QUALIFIED_DESTINATION,
    ADAPTIVE_SHIPPING_STATE_INVALID,
    FULFILLMENT_ORDER_INVALID,
    KILL_SWITCH,
    PURCHASE_FAILED,
    RATES_NOT_FOUND,
    TERMS_OF_SERVICE_NOT_ACCEPTED,
    CARRIER_NOT_SUPPORTED,
    ACCESS_DENIED,
    PACKAGE_CARRIER_MISMATCH,
}