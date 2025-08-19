#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the Page query.
/// </summary>
public enum PageSortKeys
{
    ID,
    PUBLISHED_AT,
    TITLE,
    UPDATED_AT,
}