#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents an installed application on a shop.
/// </summary>
public record AppInstallation : MetafieldReferencer, IGraphQLUnionCase, IGraphQLObject, IHasMetafields, INode
{
    /// <summary>
    /// The access scopes granted to the application by a merchant during installation.
    /// </summary>
    [JsonPropertyName("accessScopes")]
    public ICollection<AccessScope>? accessScopes { get; set; } = null;

    /// <summary>
    /// The active application subscriptions billed to the shop on a recurring basis.
    /// </summary>
    [JsonPropertyName("activeSubscriptions")]
    public ICollection<AppSubscription>? activeSubscriptions { get; set; } = null;

    /// <summary>
    /// All subscriptions created for a shop.
    /// </summary>
    [JsonPropertyName("allSubscriptions")]
    public AppSubscriptionConnection? allSubscriptions { get; set; } = null;

    /// <summary>
    /// Application which is installed.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// Channel associated with the installed application.
    /// </summary>
    [JsonPropertyName("channel")]
    [Obsolete("Use `publication` instead.")]
    public Channel? channel { get; set; } = null;

    /// <summary>
    /// Credits that can be used towards future app purchases.
    /// </summary>
    [JsonPropertyName("credits")]
    public AppCreditConnection? credits { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The URL to launch the application.
    /// </summary>
    [JsonPropertyName("launchUrl")]
    public string? launchUrl { get; set; } = null;

    /// <summary>
    /// A [custom field](https://shopify.dev/docs/apps/build/custom-data),
    /// including its `namespace` and `key`, that's associated with a Shopify resource
    /// for the purposes of adding and storing additional information.
    /// </summary>
    [JsonPropertyName("metafield")]
    public Metafield? metafield { get; set; } = null;

    /// <summary>
    /// A list of [custom fields](https://shopify.dev/docs/apps/build/custom-data)
    /// that a merchant associates with a Shopify resource.
    /// </summary>
    [JsonPropertyName("metafields")]
    public MetafieldConnection? metafields { get; set; } = null;

    /// <summary>
    /// One-time purchases to a shop.
    /// </summary>
    [JsonPropertyName("oneTimePurchases")]
    public AppPurchaseOneTimeConnection? oneTimePurchases { get; set; } = null;

    /// <summary>
    /// The publication associated with the installed application.
    /// </summary>
    [JsonPropertyName("publication")]
    public Publication? publication { get; set; } = null;

    /// <summary>
    /// The records that track the externally-captured revenue for the app. The records are used for revenue attribution purposes.
    /// </summary>
    [JsonPropertyName("revenueAttributionRecords")]
    public AppRevenueAttributionRecordConnection? revenueAttributionRecords { get; set; } = null;

    /// <summary>
    /// Subscriptions charge to a shop on a recurring basis.
    /// </summary>
    [JsonPropertyName("subscriptions")]
    [Obsolete("Use `activeSubscriptions` instead.")]
    public ICollection<AppSubscription>? subscriptions { get; set; } = null;

    /// <summary>
    /// The URL to uninstall the application.
    /// </summary>
    [JsonPropertyName("uninstallUrl")]
    public string? uninstallUrl { get; set; } = null;
}