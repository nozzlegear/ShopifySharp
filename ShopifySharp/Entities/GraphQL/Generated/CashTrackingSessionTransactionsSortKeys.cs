#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the CashTrackingSessionTransactions query.
/// </summary>
public enum CashTrackingSessionTransactionsSortKeys
{
    ID,
    PROCESSED_AT,
}