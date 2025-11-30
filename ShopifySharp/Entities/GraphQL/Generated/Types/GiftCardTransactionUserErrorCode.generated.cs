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
/// Possible error codes that can be returned by `GiftCardTransactionUserError`.
/// </summary>
public enum GiftCardTransactionUserErrorCode
{
    INVALID,
    INTERNAL_ERROR,
    GIFT_CARD_LIMIT_EXCEEDED,
    GIFT_CARD_NOT_FOUND,
    NEGATIVE_OR_ZERO_AMOUNT,
    INSUFFICIENT_FUNDS,
    MISMATCHING_CURRENCY,
}