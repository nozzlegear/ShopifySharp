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
/// Represents monetary credits that merchants can apply toward future app
/// purchases, subscriptions, or usage-based billing within their Shopify store. App
/// credits provide a flexible way to offer refunds, promotional credits, or
/// compensation without processing external payments.
/// For example, if a merchant experiences service downtime, an app might issue
/// credits equivalent to the affected billing period. These credits can apply to
/// future charges, reducing the merchant's next invoice or extending their
/// subscription period.
/// Use the `AppCredit` object to:
/// - Issue refunds for service interruptions or billing disputes
/// - Provide promotional credits for new merchant onboarding
/// - Compensate merchants for app-related issues or downtime
/// - Create loyalty rewards or referral bonuses within your billing system
/// - Track credit balances and application history for accounting purposes
/// For comprehensive billing strategies and credit management patterns, see the
/// [subscription billing
/// guide](https://shopify.dev/docs/apps/launch/billing/subscription-billing).
/// </summary>
public record AppCredit : IGraphQLObject, INode
{
    /// <summary>
    /// The amount that can be used towards future app purchases in Shopify.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyV2? amount { get; set; } = null;

    /// <summary>
    /// The date and time when the app credit was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// The description of the app credit.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether the app credit is a test transaction.
    /// </summary>
    [JsonPropertyName("test")]
    public bool? test { get; set; } = null;
}