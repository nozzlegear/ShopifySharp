#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

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