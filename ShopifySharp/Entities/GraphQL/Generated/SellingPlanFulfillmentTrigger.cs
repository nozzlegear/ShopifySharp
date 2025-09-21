#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Describes what triggers fulfillment.
/// </summary>
public enum SellingPlanFulfillmentTrigger
{
    ANCHOR,
    ASAP,
    EXACT_TIME,
    UNKNOWN,
}