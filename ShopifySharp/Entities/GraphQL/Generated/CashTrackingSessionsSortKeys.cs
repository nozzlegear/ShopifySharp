#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the CashTrackingSessions query.
/// </summary>
public enum CashTrackingSessionsSortKeys
{
    CLOSING_TIME_ASC,
    CLOSING_TIME_DESC,
    ID,
    OPENING_TIME_ASC,
    OPENING_TIME_DESC,
    TOTAL_DISCREPANCY_ASC,
    TOTAL_DISCREPANCY_DESC,
}