#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The status of the app subscription.
/// </summary>
public enum AppSubscriptionStatus
{
    PENDING,
    [Obsolete("When a merchant approves an app subscription, the status immediately transitions from `pending` to `active`.")]
    ACCEPTED,
    ACTIVE,
    DECLINED,
    EXPIRED,
    FROZEN,
    CANCELLED,
}