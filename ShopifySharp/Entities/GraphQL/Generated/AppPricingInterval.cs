#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The frequency at which the shop is billed for an app subscription.
/// </summary>
public enum AppPricingInterval
{
    ANNUAL,
    EVERY_30_DAYS,
}