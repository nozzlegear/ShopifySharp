#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the Discount query.
/// </summary>
public enum DiscountSortKeys
{
    CREATED_AT,
    ENDS_AT,
    ID,
    RELEVANCE,
    STARTS_AT,
    TITLE,
    UPDATED_AT,
}