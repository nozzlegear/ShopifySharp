#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the GiftCard query.
/// </summary>
public enum GiftCardSortKeys
{
    AMOUNT_SPENT,
    BALANCE,
    CODE,
    CREATED_AT,
    CUSTOMER_NAME,
    DISABLED_AT,
    EXPIRES_ON,
    ID,
    INITIAL_VALUE,
    UPDATED_AT,
}