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
/// Describes what triggers fulfillment.
/// </summary>
public enum SellingPlanFulfillmentTrigger
{
    ANCHOR,
    ASAP,
    EXACT_TIME,
    UNKNOWN,
}