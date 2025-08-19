#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The application level for a market condition.
/// </summary>
public enum MarketConditionApplicationType
{
    SPECIFIED,
    ALL,
}