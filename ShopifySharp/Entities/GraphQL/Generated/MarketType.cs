#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The market types.
/// </summary>
public enum MarketType
{
    NONE,
    REGION,
    LOCATION,
    COMPANY_LOCATION,
}