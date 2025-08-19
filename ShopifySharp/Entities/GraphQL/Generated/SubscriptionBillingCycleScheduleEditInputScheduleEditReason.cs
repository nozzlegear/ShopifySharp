#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for possible reasons for editing the billing cycle's schedule.
/// </summary>
public enum SubscriptionBillingCycleScheduleEditInputScheduleEditReason
{
    BUYER_INITIATED,
    MERCHANT_INITIATED,
    DEV_INITIATED,
}