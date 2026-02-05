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
/// The pricing model for the app subscription.
/// The pricing model input can be either `appRecurringPricingDetails` or `appUsagePricingDetails`.
/// </summary>
public record AppPlanInput : GraphQLInputObject<AppPlanInput>
{
    /// <summary>
    /// The pricing details for recurring billing.
    /// </summary>
    [JsonPropertyName("appRecurringPricingDetails")]
    public AppRecurringPricingInput? appRecurringPricingDetails { get; set; } = null;

    /// <summary>
    /// The pricing details for usage-based billing.
    /// </summary>
    [JsonPropertyName("appUsagePricingDetails")]
    public AppUsagePricingInput? appUsagePricingDetails { get; set; } = null;
}