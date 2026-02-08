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
/// Represents valid selling plan interval.
/// </summary>
public enum SellingPlanInterval
{
    DAY,
    WEEK,
    MONTH,
    YEAR,
}