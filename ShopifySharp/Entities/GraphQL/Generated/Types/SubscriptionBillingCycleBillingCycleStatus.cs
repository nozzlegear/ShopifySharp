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
/// The possible status values of a subscription billing cycle.
/// </summary>
public enum SubscriptionBillingCycleBillingCycleStatus
{
    BILLED,
    UNBILLED,
}