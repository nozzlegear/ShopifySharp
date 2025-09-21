#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Select subscription billing cycles to be targeted.
/// </summary>
public enum SubscriptionBillingCyclesTargetSelection
{
    ALL,
}