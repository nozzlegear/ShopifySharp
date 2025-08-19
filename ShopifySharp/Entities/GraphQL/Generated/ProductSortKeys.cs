#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the Product query.
/// </summary>
public enum ProductSortKeys
{
    CREATED_AT,
    ID,
    INVENTORY_TOTAL,
    PRODUCT_TYPE,
    PUBLISHED_AT,
    RELEVANCE,
    TITLE,
    UPDATED_AT,
    VENDOR,
}