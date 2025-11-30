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
/// The fulfillment or delivery behavior of the first fulfillment when the orderis placed before the anchor.
/// </summary>
public enum SellingPlanFixedDeliveryPolicyPreAnchorBehavior
{
    ASAP,
    NEXT,
}