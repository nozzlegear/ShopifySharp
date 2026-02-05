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
/// Defines usage-based pricing terms for app subscriptions where merchants pay
/// based on their actual consumption of app features or services. This pricing
/// model provides flexibility for merchants who want to pay only for what they use
/// rather than fixed monthly fees.
/// For example, an email marketing app might charge variable pricing per email
/// sent, with a monthly cap of variable pricing, allowing small merchants to pay
/// minimal amounts while protecting larger merchants from excessive charges.
/// Use the `AppUsagePricing` object to:
/// - View consumption-based billing for variable app usage
/// - See spending caps that protect merchants from unexpected charges
/// The balance and capped amount fields provide apps with data about current usage
/// costs and remaining budget within the billing period, which apps can present to
/// merchants to promote transparency in variable pricing.
/// For implementation guidance, see the [usage billing documentation](https://shopify.dev/docs/apps/launch/billing/subscription-billing/create-usage-based-subscriptions).
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