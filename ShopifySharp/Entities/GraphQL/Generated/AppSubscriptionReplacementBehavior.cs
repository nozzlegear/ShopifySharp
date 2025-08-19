#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The replacement behavior when creating an app subscription for a merchant with an already existing app subscription.
/// </summary>
public enum AppSubscriptionReplacementBehavior
{
    APPLY_IMMEDIATELY,
    APPLY_ON_NEXT_BILLING_CYCLE,
    STANDARD,
}