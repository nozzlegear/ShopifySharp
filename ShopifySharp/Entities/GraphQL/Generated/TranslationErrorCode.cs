#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `TranslationUserError`.
/// </summary>
public enum TranslationErrorCode
{
    BLANK,
    INVALID,
    RESOURCE_NOT_FOUND,
    RESOURCE_NOT_TRANSLATABLE,
    TOO_MANY_KEYS_FOR_RESOURCE,
    INVALID_KEY_FOR_MODEL,
    FAILS_RESOURCE_VALIDATION,
    INVALID_TRANSLATABLE_CONTENT,
    INVALID_MARKET_LOCALIZABLE_CONTENT,
    INVALID_LOCALE_FOR_SHOP,
    INVALID_CODE,
    INVALID_FORMAT,
    MARKET_CUSTOM_CONTENT_NOT_ALLOWED,
    MARKET_DOES_NOT_EXIST,
    MARKET_LOCALE_CREATION_FAILED,
    RESOURCE_NOT_MARKET_CUSTOMIZABLE,
    [Obsolete("`invalid_locale_for_market` is deprecated because the creation of a locale thats specific to a market no longer needs to be tied to that markets URL. ")]
    INVALID_LOCALE_FOR_MARKET,
    INVALID_VALUE_FOR_HANDLE_TRANSLATION,
}