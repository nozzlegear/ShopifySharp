#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The possible status values of a subscription billing cycle.
/// </summary>
public enum SubscriptionBillingCycleBillingCycleStatus
{
    BILLED,
    UNBILLED,
}