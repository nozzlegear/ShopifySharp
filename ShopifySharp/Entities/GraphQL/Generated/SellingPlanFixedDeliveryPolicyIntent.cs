#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible intentions of a Delivery Policy.
/// </summary>
public enum SellingPlanFixedDeliveryPolicyIntent
{
    FULFILLMENT_BEGIN,
}