#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The origin of quantity rule on a price list.
/// </summary>
public enum QuantityRuleOriginType
{
    FIXED,
    RELATIVE,
}