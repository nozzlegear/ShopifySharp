#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A standardized error code, independent of the payment provider.
/// </summary>
public enum OrderTransactionErrorCode
{
    INCORRECT_NUMBER,
    INVALID_NUMBER,
    INVALID_EXPIRY_DATE,
    INVALID_CVC,
    EXPIRED_CARD,
    INCORRECT_CVC,
    INCORRECT_ZIP,
    INCORRECT_ADDRESS,
    INCORRECT_PIN,
    CARD_DECLINED,
    PROCESSING_ERROR,
    CALL_ISSUER,
    PICK_UP_CARD,
    CONFIG_ERROR,
    TEST_MODE_LIVE_CARD,
    UNSUPPORTED_FEATURE,
    GENERIC_ERROR,
    INVALID_COUNTRY,
    INVALID_AMOUNT,
    PAYMENT_METHOD_UNAVAILABLE,
    AMAZON_PAYMENTS_INVALID_PAYMENT_METHOD,
    AMAZON_PAYMENTS_MAX_AMOUNT_CHARGED,
    AMAZON_PAYMENTS_MAX_AMOUNT_REFUNDED,
    AMAZON_PAYMENTS_MAX_AUTHORIZATIONS_CAPTURED,
    AMAZON_PAYMENTS_MAX_REFUNDS_PROCESSED,
    AMAZON_PAYMENTS_ORDER_REFERENCE_CANCELED,
    AMAZON_PAYMENTS_STALE,
}