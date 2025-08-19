#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `StoreCreditAccountCreditUserError`.
/// </summary>
public enum StoreCreditAccountCreditUserErrorCode
{
    ACCOUNT_NOT_FOUND,
    OWNER_NOT_FOUND,
    NEGATIVE_OR_ZERO_AMOUNT,
    MISMATCHING_CURRENCY,
    EXPIRES_AT_IN_PAST,
    CREDIT_LIMIT_EXCEEDED,
    UNSUPPORTED_CURRENCY,
}