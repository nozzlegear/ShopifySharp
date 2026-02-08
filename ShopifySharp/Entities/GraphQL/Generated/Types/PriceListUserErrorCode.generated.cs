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
/// Possible error codes that can be returned by `PriceListUserError`.
/// </summary>
public enum PriceListUserErrorCode
{
    TAKEN,
    BLANK,
    INCLUSION,
    TOO_LONG,
    PRICE_LIST_NOT_FOUND,
    PRICE_LIST_LOCKED,
    CURRENCY_MARKET_MISMATCH,
    INVALID_ADJUSTMENT_VALUE,
    INVALID_ADJUSTMENT_MIN_VALUE,
    INVALID_ADJUSTMENT_MAX_VALUE,
    CATALOG_CONTEXT_DOES_NOT_SUPPORT_QUANTITY_RULES,
    CATALOG_CONTEXT_DOES_NOT_SUPPORT_QUANTITY_PRICE_BREAKS,
    CONTEXT_RULE_LIMIT_ONE_OPTION,
    CURRENCY_NOT_SUPPORTED,
    PRICE_LIST_NOT_ALLOWED_FOR_PRIMARY_MARKET,
    CATALOG_DOES_NOT_EXIST,
    CATALOG_MARKET_AND_PRICE_LIST_CURRENCY_MISMATCH,
    CATALOG_TAKEN,
    COUNTRY_PRICE_LIST_ASSIGNMENT,
    GENERIC_ERROR,
}