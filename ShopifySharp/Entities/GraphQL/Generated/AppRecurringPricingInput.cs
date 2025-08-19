#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Instructs the app subscription to generate a fixed charge on a recurring basis.
/// The frequency is specified by the billing interval.
/// </summary>
public record AppRecurringPricingInput : GraphQLInputObject<AppRecurringPricingInput>
{
    /// <summary>
    /// The discount applied to the subscription for a given number of billing intervals.
    /// </summary>
    [JsonPropertyName("discount")]
    public AppSubscriptionDiscountInput? discount { get; set; } = null;

    /// <summary>
    /// How often the app subscription generates a charge.
    /// </summary>
    [JsonPropertyName("interval")]
    public AppPricingInterval? interval { get; set; } = null;

    /// <summary>
    /// The amount to be charged to the store every billing interval.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyInput? price { get; set; } = null;
}