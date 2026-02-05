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
/// Tracks a [customer](https://shopify.dev/docs/api/admin-graphql/latest/objects/Customer)'s
/// incomplete shopping journey, whether they abandoned while browsing
/// [products](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product),
/// adding items to cart, or during checkout. Provides data about the customer's
/// behavior and products they interacted with.
/// The abandonment includes fields that indicate whether the customer has completed
/// any [orders](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order) or [draft
/// orders](https://shopify.dev/docs/api/admin-graphql/latest/objects/DraftOrder)
/// after the abandonment occurred. It also tracks when emails were sent and how
/// long since the customer's last activity across different abandonment types.
/// </summary>
public record Abandonment : IGraphQLObject, INode
{
    /// <summary>
    /// The abandonment payload for the abandoned checkout.
    /// </summary>
    [JsonPropertyName("abandonedCheckoutPayload")]
    public AbandonedCheckout? abandonedCheckoutPayload { get; set; } = null;

    /// <summary>
    /// The abandonment type.
    /// </summary>
    [JsonPropertyName("abandonmentType")]
    public AbandonmentAbandonmentType? abandonmentType { get; set; } = null;

    /// <summary>
    /// The app associated with an abandoned checkout.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// Permalink to the cart page.
    /// </summary>
    [JsonPropertyName("cartUrl")]
    public string? cartUrl { get; set; } = null;

    /// <summary>
    /// The date and time when the abandonment was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// The customer who abandoned this event.
    /// </summary>
    [JsonPropertyName("customer")]
    public Customer? customer { get; set; } = null;

    /// <summary>
    /// Whether the customer has a draft order since this abandonment has been abandoned.
    /// </summary>
    [JsonPropertyName("customerHasNoDraftOrderSinceAbandonment")]
    public bool? customerHasNoDraftOrderSinceAbandonment { get; set; } = null;

    /// <summary>
    /// Whether the customer has completed an order since this checkout has been abandoned.
    /// </summary>
    [JsonPropertyName("customerHasNoOrderSinceAbandonment")]
    public bool? customerHasNoOrderSinceAbandonment { get; set; } = null;

    /// <summary>
    /// The number of days since the last abandonment email was sent to the customer.
    /// </summary>
    [JsonPropertyName("daysSinceLastAbandonmentEmail")]
    public int? daysSinceLastAbandonmentEmail { get; set; } = null;

    /// <summary>
    /// When the email was sent, if that's the case.
    /// </summary>
    [JsonPropertyName("emailSentAt")]
    public DateTimeOffset? emailSentAt { get; set; } = null;

    /// <summary>
    /// The email state (e.g., sent or not sent).
    /// </summary>
    [JsonPropertyName("emailState")]
    public AbandonmentEmailState? emailState { get; set; } = null;

    /// <summary>
    /// The number of hours since the customer has last abandoned a checkout.
    /// </summary>
    [JsonPropertyName("hoursSinceLastAbandonedCheckout")]
    public decimal? hoursSinceLastAbandonedCheckout { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether the products in abandonment are available.
    /// </summary>
    [JsonPropertyName("inventoryAvailable")]
    public bool? inventoryAvailable { get; set; } = null;

    /// <summary>
    /// Whether the abandonment event comes from a custom storefront channel.
    /// </summary>
    [JsonPropertyName("isFromCustomStorefront")]
    public bool? isFromCustomStorefront { get; set; } = null;

    /// <summary>
    /// Whether the abandonment event comes from the Online Store sales channel.
    /// </summary>
    [JsonPropertyName("isFromOnlineStore")]
    public bool? isFromOnlineStore { get; set; } = null;

    /// <summary>
    /// Whether the abandonment event comes from the Shop app sales channel.
    /// </summary>
    [JsonPropertyName("isFromShopApp")]
    public bool? isFromShopApp { get; set; } = null;

    /// <summary>
    /// Whether the abandonment event comes from Shop Pay.
    /// </summary>
    [JsonPropertyName("isFromShopPay")]
    public bool? isFromShopPay { get; set; } = null;

    /// <summary>
    /// Whether the customer didn't complete another most significant step since this abandonment.
    /// </summary>
    [JsonPropertyName("isMostSignificantAbandonment")]
    public bool? isMostSignificantAbandonment { get; set; } = null;

    /// <summary>
    /// The date for the latest browse abandonment.
    /// </summary>
    [JsonPropertyName("lastBrowseAbandonmentDate")]
    public DateTimeOffset? lastBrowseAbandonmentDate { get; set; } = null;

    /// <summary>
    /// The date for the latest cart abandonment.
    /// </summary>
    [JsonPropertyName("lastCartAbandonmentDate")]
    public DateTimeOffset? lastCartAbandonmentDate { get; set; } = null;

    /// <summary>
    /// The date for the latest checkout abandonment.
    /// </summary>
    [JsonPropertyName("lastCheckoutAbandonmentDate")]
    public DateTimeOffset? lastCheckoutAbandonmentDate { get; set; } = null;

    /// <summary>
    /// The most recent step type.
    /// </summary>
    [JsonPropertyName("mostRecentStep")]
    public AbandonmentAbandonmentType? mostRecentStep { get; set; } = null;

    /// <summary>
    /// The products added to the cart during the customer abandoned visit.
    /// </summary>
    [JsonPropertyName("productsAddedToCart")]
    public CustomerVisitProductInfoConnection? productsAddedToCart { get; set; } = null;

    /// <summary>
    /// The products viewed during the customer abandoned visit.
    /// </summary>
    [JsonPropertyName("productsViewed")]
    public CustomerVisitProductInfoConnection? productsViewed { get; set; } = null;

    /// <summary>
    /// The date and time when the visit started.
    /// </summary>
    [JsonPropertyName("visitStartedAt")]
    public DateTimeOffset? visitStartedAt { get; set; } = null;
}