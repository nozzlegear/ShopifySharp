#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `PriceListPriceUserError`.
/// </summary>
public enum PriceListPriceUserErrorCode
{
    BLANK,
    PRICE_LIST_NOT_FOUND,
    PRICE_LIST_CURRENCY_MISMATCH,
    VARIANT_NOT_FOUND,
    PRICE_NOT_FIXED,
}