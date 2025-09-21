#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Specifies the sort order for the products in the collection.
/// </summary>
public enum CollectionSortOrder
{
    ALPHA_ASC,
    ALPHA_DESC,
    BEST_SELLING,
    CREATED,
    CREATED_DESC,
    MANUAL,
    PRICE_ASC,
    PRICE_DESC,
}