#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record AppPricingDetailsAppRecurringPricing(AppRecurringPricing Value): AppPricingDetails;
internal record AppPricingDetailsAppUsagePricing(AppUsagePricing Value): AppPricingDetails;
#endif /// <summary>

/// The frequency at which the shop is billed for an app subscription.
/// </summary>
public enum AppPricingInterval
{
    ANNUAL,
    EVERY_30_DAYS,
}