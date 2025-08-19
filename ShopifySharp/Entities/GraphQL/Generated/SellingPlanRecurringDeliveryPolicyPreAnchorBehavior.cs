#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The fulfillment or delivery behaviors of the first fulfillment when the orderis placed before the anchor.
/// </summary>
public enum SellingPlanRecurringDeliveryPolicyPreAnchorBehavior
{
    ASAP,
    NEXT,
}