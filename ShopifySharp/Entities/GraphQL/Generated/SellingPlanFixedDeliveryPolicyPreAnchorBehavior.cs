#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The fulfillment or delivery behavior of the first fulfillment when the orderis placed before the anchor.
/// </summary>
public enum SellingPlanFixedDeliveryPolicyPreAnchorBehavior
{
    ASAP,
    NEXT,
}