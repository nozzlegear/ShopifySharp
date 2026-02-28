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
/// Represents a one-time purchase of app services or features by a merchant,
/// tracking the transaction details and status throughout the billing lifecycle.
/// This object captures essential information about non-recurring charges,
/// including price and merchant acceptance status.
/// One-time purchases are particularly valuable for apps offering premium features,
/// professional services, or digital products that don't require ongoing
/// subscriptions. For instance, a photography app might sell premium filters as
/// one-time purchases, while a marketing app could charge for individual campaign
/// setups or advanced analytics reports.
/// Use the `AppPurchaseOneTime` object to:
/// - Track the status of individual feature purchases and service charges
/// - Track payment status for premium content or digital products
/// - Access purchase details to enable or disable features based on payment status
/// The purchase status indicates whether the charge is pending merchant approval,
/// has been accepted and processed, or was declined. This status tracking is
/// crucial for apps that need to conditionally enable features based on successful
/// payment completion.
/// Purchase records include creation timestamps, pricing details, and test flags to
/// distinguish between production charges and development testing. The test flag
/// ensures that development and staging environments don't generate actual charges
/// while maintaining realistic billing flow testing.
/// For detailed implementation patterns and billing best practices, see the
/// [one-time-charges
/// page](https://shopify.dev/docs/apps/launch/billing/one-time-charges).
/// </summary>
public record AppPurchaseOneTime : IGraphQLObject, IAppPurchase, INode
{
    /// <summary>
    /// The date and time when the app purchase occurred.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The name of the app purchase.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The amount to be charged to the store for the app purchase.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyV2? price { get; set; } = null;

    /// <summary>
    /// The status of the app purchase.
    /// </summary>
    [JsonPropertyName("status")]
    public AppPurchaseStatus? status { get; set; } = null;

    /// <summary>
    /// Whether the app purchase is a test transaction.
    /// </summary>
    [JsonPropertyName("test")]
    public bool? test { get; set; } = null;
}