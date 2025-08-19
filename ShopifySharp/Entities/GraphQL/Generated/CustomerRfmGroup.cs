#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The RFM (Recency, Frequency, Monetary) group for a customer.
/// </summary>
public enum CustomerRfmGroup
{
    CHAMPIONS,
    LOYAL,
    ACTIVE,
    NEW,
    PROMISING,
    NEEDS_ATTENTION,
    ALMOST_LOST,
    PREVIOUSLY_LOYAL,
    AT_RISK,
    DORMANT,
    PROSPECTS,
}