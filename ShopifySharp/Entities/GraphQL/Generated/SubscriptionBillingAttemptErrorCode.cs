#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The possible error codes associated with making billing attempts. The error codes supplement the
/// `error_message` to provide consistent results and help with dunning management.
/// </summary>
public enum SubscriptionBillingAttemptErrorCode
{
    PAYMENT_METHOD_NOT_FOUND,
    PAYMENT_PROVIDER_IS_NOT_ENABLED,
    INVALID_PAYMENT_METHOD,
    UNEXPECTED_ERROR,
    EXPIRED_PAYMENT_METHOD,
    PAYMENT_METHOD_DECLINED,
    AUTHENTICATION_ERROR,
    TEST_MODE,
    BUYER_CANCELED_PAYMENT_METHOD,
    CUSTOMER_NOT_FOUND,
    CUSTOMER_INVALID,
    INVALID_SHIPPING_ADDRESS,
    INVALID_CUSTOMER_BILLING_AGREEMENT,
    INVOICE_ALREADY_PAID,
    PAYMENT_METHOD_INCOMPATIBLE_WITH_GATEWAY_CONFIG,
    AMOUNT_TOO_SMALL,
    INVENTORY_ALLOCATIONS_NOT_FOUND,
    INSUFFICIENT_INVENTORY,
    TRANSIENT_ERROR,
    INSUFFICIENT_FUNDS,
    PURCHASE_TYPE_NOT_SUPPORTED,
    PAYPAL_ERROR_GENERAL,
    CARD_NUMBER_INCORRECT,
    FRAUD_SUSPECTED,
    NON_TEST_ORDER_LIMIT_REACHED,
    FREE_GIFT_CARD_NOT_ALLOWED,
}