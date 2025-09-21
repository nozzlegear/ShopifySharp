#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// When to capture the payment for the remaining amount due.
/// </summary>
public enum SellingPlanRemainingBalanceChargeTrigger
{
    NO_REMAINING_BALANCE,
    EXACT_TIME,
    TIME_AFTER_CHECKOUT,
}