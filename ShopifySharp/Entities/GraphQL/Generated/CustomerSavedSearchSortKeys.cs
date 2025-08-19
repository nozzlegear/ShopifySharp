#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the CustomerSavedSearch query.
/// </summary>
public enum CustomerSavedSearchSortKeys
{
    ID,
    NAME,
}