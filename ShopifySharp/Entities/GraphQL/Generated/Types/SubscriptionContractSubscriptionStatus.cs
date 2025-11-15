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