#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `MarketCurrencySettingsUserError`.
/// </summary>
public enum MarketCurrencySettingsUserErrorCode
{
    MARKET_NOT_FOUND,
    MANAGED_MARKET,
    UNIFIED_MARKETS_ENABLED,
    MULTIPLE_CURRENCIES_NOT_SUPPORTED,
    NO_LOCAL_CURRENCIES_ON_SINGLE_COUNTRY_MARKET,
    UNSUPPORTED_CURRENCY,
    PRIMARY_MARKET_USES_SHOP_CURRENCY,
}