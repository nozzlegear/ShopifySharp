#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The set of valid sort keys for the ProfileItem query.
/// </summary>
public enum ProfileItemSortKeys
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