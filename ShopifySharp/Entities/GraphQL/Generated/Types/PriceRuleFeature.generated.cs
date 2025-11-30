#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The list of features that can be supported by a price rule.
/// </summary>
public enum PriceRuleFeature
{
    BUY_ONE_GET_ONE,
    BUY_ONE_GET_ONE_WITH_ALLOCATION_LIMIT,
    BULK,
    SPECIFIC_CUSTOMERS,
    QUANTITY_DISCOUNTS,
}