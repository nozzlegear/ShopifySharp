#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The presence of billing attempts on Billing Cycles.
/// </summary>
public enum SubscriptionBillingCycleBillingAttemptStatus
{
    HAS_ATTEMPT,
    NO_ATTEMPT,
    ANY,
}