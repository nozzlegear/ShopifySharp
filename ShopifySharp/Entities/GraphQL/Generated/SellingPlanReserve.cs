#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// When to reserve inventory for a selling plan.
/// </summary>
public enum SellingPlanReserve
{
    ON_FULFILLMENT,
    ON_SALE,
}