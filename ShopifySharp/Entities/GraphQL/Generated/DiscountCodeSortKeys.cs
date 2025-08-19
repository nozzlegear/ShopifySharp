#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the DiscountCode query.
/// </summary>
public enum DiscountCodeSortKeys
{
    CODE,
    CREATED_AT,
    ID,
    RELEVANCE,
}