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
/// Error codes for other billing attempt failures.
/// </summary>
public enum SubscriptionBillingAttemptGeneralErrorCode
{
    NON_TEST_ORDER_LIMIT_REACHED,
    FREE_GIFT_CARD_NOT_ALLOWED,
    CUSTOMER_NOT_FOUND,
    CUSTOMER_INVALID,
    INVALID_BILLING_ADDRESS,
    MERCHANT_ACCOUNT_ERROR,
    PAYMENT_METHOD_NOT_FOUND,
    PAYMENT_METHOD_NOT_SPECIFIED,
    PAYMENT_METHOD_INCOMPATIBLE_WITH_GATEWAY_CONFIG,
    PAYMENT_PROVIDER_IS_NOT_ENABLED,
}