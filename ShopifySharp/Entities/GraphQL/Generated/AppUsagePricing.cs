#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Defines a usage pricing model for the app subscription.
/// These charges are variable based on how much the merchant uses the app.
/// </summary>
public record AppUsagePricing : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The total usage records for interval.
    /// </summary>
    [JsonPropertyName("balanceUsed")]
    public MoneyV2? balanceUsed { get; set; } = null;

    /// <summary>
    /// The capped amount prevents the merchant from being charged for any usage over that amount during a billing period.
    /// This prevents billing from exceeding a maximum threshold over the duration of the billing period.
    /// For the merchant to continue using the app after exceeding a capped amount,
    /// they would need to agree to a new usage charge.
    /// </summary>
    [JsonPropertyName("cappedAmount")]
    public MoneyV2? cappedAmount { get; set; } = null;

    /// <summary>
    /// The frequency with which the app usage records are billed.
    /// </summary>
    [JsonPropertyName("interval")]
    public AppPricingInterval? interval { get; set; } = null;

    /// <summary>
    /// The terms and conditions for app usage pricing.
    /// Must be present in order to create usage charges.
    /// The terms are presented to the merchant when they approve an app's usage charges.
    /// </summary>
    [JsonPropertyName("terms")]
    public string? terms { get; set; } = null;
}