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
/// When to capture the payment for the remaining amount due.
/// </summary>
public enum SellingPlanRemainingBalanceChargeTrigger
{
    NO_REMAINING_BALANCE,
    EXACT_TIME,
    TIME_AFTER_CHECKOUT,
    ON_FULFILLMENT,
}