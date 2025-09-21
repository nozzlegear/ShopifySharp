#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `StoreCreditAccountDebitUserError`.
/// </summary>
public enum StoreCreditAccountDebitUserErrorCode
{
    ACCOUNT_NOT_FOUND,
    NEGATIVE_OR_ZERO_AMOUNT,
    INSUFFICIENT_FUNDS,
    MISMATCHING_CURRENCY,
}