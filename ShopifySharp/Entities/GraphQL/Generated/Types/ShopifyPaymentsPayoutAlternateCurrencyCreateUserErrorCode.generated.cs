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
/// Possible error codes that can be returned by `ShopifyPaymentsPayoutAlternateCurrencyCreateUserError`.
/// </summary>
public enum ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorCode
{
    MISSING_PROVIDER_ACCOUNT,
    ALTERNATE_CURRENCY_PAYOUT_FAILED_STRIPE_ERROR,
    UNKNOWN_CORE_ERROR,
    ALTERNATE_CURRENCY_PAYOUT_FAILED_NO_ELIGIBLE_BALANCE,
}