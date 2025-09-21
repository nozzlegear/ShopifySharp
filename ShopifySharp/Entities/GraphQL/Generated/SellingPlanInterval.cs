#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents valid selling plan interval.
/// </summary>
public enum SellingPlanInterval
{
    DAY,
    WEEK,
    MONTH,
    YEAR,
}