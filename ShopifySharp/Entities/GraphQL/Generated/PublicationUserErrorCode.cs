#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `PublicationUserError`.
/// </summary>
public enum PublicationUserErrorCode
{
    UNSUPPORTED_PUBLICATION_ACTION,
    PUBLICATION_NOT_FOUND,
    PUBLICATION_LOCKED,
    UNSUPPORTED_PUBLISHABLE_TYPE,
    INVALID_PUBLISHABLE_ID,
    MARKET_NOT_FOUND,
    CATALOG_NOT_FOUND,
    CANNOT_MODIFY_APP_CATALOG_PUBLICATION,
    CANNOT_MODIFY_MARKET_CATALOG_PUBLICATION,
    CANNOT_MODIFY_APP_CATALOG,
    CANNOT_MODIFY_MARKET_CATALOG,
    INVALID,
    TAKEN,
    TOO_LONG,
    TOO_SHORT,
    BLANK,
    PRODUCT_TYPE_INCOMPATIBLE_WITH_CATALOG_TYPE,
    PUBLICATION_UPDATE_LIMIT_EXCEEDED,
}