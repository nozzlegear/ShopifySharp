#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The valid tiers for the predicted spend of a customer with a shop.
/// </summary>
public enum CustomerPredictedSpendTier
{
    HIGH,
    MEDIUM,
    LOW,
}