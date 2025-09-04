#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The pricing information about a subscription app.
/// The object contains an interval (the frequency at which the shop is billed for an app subscription) and
/// a price (the amount to be charged to the subscribing shop at each interval).
/// </summary>
public record AppRecurringPricing : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The discount applied to the subscription for a given number of billing intervals.
    /// </summary>
    [JsonPropertyName("discount")]
    public AppSubscriptionDiscount? discount { get; set; } = null;

    /// <summary>
    /// The frequency at which the subscribing shop is billed for an app subscription.
    /// </summary>
    [JsonPropertyName("interval")]
    public AppPricingInterval? interval { get; set; } = null;

    /// <summary>
    /// The app store pricing plan handle.
    /// </summary>
    [JsonPropertyName("planHandle")]
    public string? planHandle { get; set; } = null;

    /// <summary>
    /// The amount and currency to be charged to the subscribing shop every billing interval.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyV2? price { get; set; } = null;
}