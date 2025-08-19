#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the AppTransaction query.
/// </summary>
public enum AppTransactionSortKeys
{
    CREATED_AT,
    ID,
}