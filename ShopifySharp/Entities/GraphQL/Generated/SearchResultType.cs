#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Specifies the type of resources to be returned from a search.
/// </summary>
public enum SearchResultType
{
    CUSTOMER,
    DRAFT_ORDER,
    PRODUCT,
    COLLECTION,
    FILE,
    PAGE,
    BLOG,
    ARTICLE,
    URL_REDIRECT,
    PRICE_RULE,
    DISCOUNT_REDEEM_CODE,
    ORDER,
    BALANCE_TRANSACTION,
}