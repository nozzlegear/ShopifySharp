#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `ShopifyPaymentsPayoutAlternateCurrencyCreateUserError`.
/// </summary>
public enum ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorCode
{
    MISSING_PROVIDER_ACCOUNT,
    ALTERNATE_CURRENCY_PAYOUT_FAILED_STRIPE_ERROR,
    UNKNOWN_CORE_ERROR,
    ALTERNATE_CURRENCY_PAYOUT_FAILED_NO_ELIGIBLE_BALANCE,
}