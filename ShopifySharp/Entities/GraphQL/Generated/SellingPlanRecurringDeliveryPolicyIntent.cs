#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Whether the delivery policy is merchant or buyer-centric.
/// </summary>
public enum SellingPlanRecurringDeliveryPolicyIntent
{
    FULFILLMENT_BEGIN,
}