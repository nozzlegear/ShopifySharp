#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The set of valid sort keys for the Markets query.
/// </summary>
public enum MarketsSortKeys
{
    CREATED_AT,
    ID,
    MARKET_CONDITION_TYPES,
    MARKET_TYPE,
    NAME,
    UPDATED_AT,
}