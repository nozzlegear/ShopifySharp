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
/// Represents a component of an app subscription that contains pricing details for
/// either recurring fees or usage-based charges. Each subscription has exactly 1 or
/// 2 line items - one for recurring fees and/or one for usage fees.
/// If a subscription has both recurring and usage pricing, there will be 2 line
/// items. If it only has one type of pricing, the subscription will have a single
/// line item for that pricing model.
/// Use the `AppSubscriptionLineItem` object to:
/// - View the pricing terms a merchant has agreed to
/// - Distinguish between recurring and usage fee components
/// - Access detailed billing information for each pricing component
/// This read-only object provides visibility into the subscription's pricing structure without allowing modifications.
/// Read about subscription pricing models in the [billing architecture
/// guide](https://shopify.dev/docs/apps/launch/billing/subscription-billing).
/// </summary>
public record AppSubscriptionLineItem : IGraphQLObject
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The pricing model for the app subscription.
    /// </summary>
    [JsonPropertyName("plan")]
    public AppPlanV2? plan { get; set; } = null;

    /// <summary>
    /// A list of the store's usage records for a usage pricing plan.
    /// </summary>
    [JsonPropertyName("usageRecords")]
    public AppUsageRecordConnection? usageRecords { get; set; } = null;
}