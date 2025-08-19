#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for products belonging to a collection.
/// </summary>
public enum ProductCollectionSortKeys
{
    BEST_SELLING,
    COLLECTION_DEFAULT,
    CREATED,
    ID,
    MANUAL,
    PRICE,
    RELEVANCE,
    TITLE,
}