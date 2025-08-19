#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the Company query.
/// </summary>
public enum CompanySortKeys
{
    CREATED_AT,
    ID,
    NAME,
    ORDER_COUNT,
    SINCE_DATE,
    TOTAL_SPENT,
    UPDATED_AT,
}