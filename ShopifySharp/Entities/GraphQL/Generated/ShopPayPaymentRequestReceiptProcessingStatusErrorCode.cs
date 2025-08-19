#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A standardized error code, independent of the payment provider.
/// </summary>
public enum ShopPayPaymentRequestReceiptProcessingStatusErrorCode
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
    AMOUNT_TOO_SMALL,
    CARD_DECLINED,
    PROCESSING_ERROR,
    CALL_ISSUER,
    THREE_D_SECURE_FAILED,
    FRAUD_SUSPECTED,
    PICK_UP_CARD,
    CONFIG_ERROR,
    TEST_MODE_LIVE_CARD,
    UNSUPPORTED_FEATURE,
    GENERIC_ERROR,
    INVALID_COUNTRY,
    INVALID_AMOUNT,
    PAYMENT_METHOD_UNAVAILABLE,
}