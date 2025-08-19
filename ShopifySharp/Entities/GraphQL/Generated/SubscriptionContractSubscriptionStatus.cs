#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The possible status values of a subscription.
/// </summary>
public enum SubscriptionContractSubscriptionStatus
{
    ACTIVE,
    PAUSED,
    CANCELLED,
    EXPIRED,
    FAILED,
}