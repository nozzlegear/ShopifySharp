#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The status of the price rule.
/// </summary>
public enum PriceRuleStatus
{
    ACTIVE,
    EXPIRED,
    SCHEDULED,
}