#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The condition types for the condition set.
/// </summary>
public enum MarketConditionType
{
    REGION,
    LOCATION,
    COMPANY_LOCATION,
}