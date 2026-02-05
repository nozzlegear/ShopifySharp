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
/// The input fields for possible reasons for editing the billing cycle's schedule.
/// </summary>
public enum SubscriptionBillingCycleScheduleEditInputScheduleEditReason
{
    BUYER_INITIATED,
    MERCHANT_INITIATED,
    DEV_INITIATED,
}