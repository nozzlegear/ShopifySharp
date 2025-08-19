#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the Transaction query.
/// </summary>
public enum TransactionSortKeys
{
    CREATED_AT,
    EXPIRES_AT,
}