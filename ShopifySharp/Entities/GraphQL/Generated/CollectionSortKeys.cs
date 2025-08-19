#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the Collection query.
/// </summary>
public enum CollectionSortKeys
{
    ID,
    RELEVANCE,
    TITLE,
    UPDATED_AT,
}