#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `PriceListFixedPricesByProductBulkUpdateUserError`.
/// </summary>
public enum PriceListFixedPricesByProductBulkUpdateUserErrorCode
{
    NO_UPDATE_OPERATIONS_SPECIFIED,
    PRICES_TO_ADD_CURRENCY_MISMATCH,
    PRICE_LIST_DOES_NOT_EXIST,
    DUPLICATE_ID_IN_INPUT,
    ID_MUST_BE_MUTUALLY_EXCLUSIVE,
    PRODUCT_DOES_NOT_EXIST,
    PRICE_LIMIT_EXCEEDED,
}