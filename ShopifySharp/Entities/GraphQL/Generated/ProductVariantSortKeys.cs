#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the ProductVariant query.
/// </summary>
public enum ProductVariantSortKeys
{
    FULL_TITLE,
    ID,
    INVENTORY_LEVELS_AVAILABLE,
    INVENTORY_MANAGEMENT,
    INVENTORY_POLICY,
    INVENTORY_QUANTITY,
    NAME,
    POPULAR,
    POSITION,
    RELEVANCE,
    SKU,
    TITLE,
}