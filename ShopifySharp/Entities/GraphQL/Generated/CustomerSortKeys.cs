#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the Customer query.
/// </summary>
public enum CustomerSortKeys
{
    CREATED_AT,
    ID,
    LOCATION,
    NAME,
    RELEVANCE,
    UPDATED_AT,
}