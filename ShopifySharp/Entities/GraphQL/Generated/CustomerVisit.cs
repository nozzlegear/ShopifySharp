#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a customer's session visiting a shop's online store, including
/// information about the marketing activity attributed to starting the session.
/// </summary>
public record CustomerVisit : IGraphQLObject, ICustomerMoment, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// URL of the first page the customer landed on for the session.
    /// </summary>
    [JsonPropertyName("landingPage")]
    public string? landingPage { get; set; } = null;

    /// <summary>
    /// Landing page information with URL linked in HTML. For example, the first page
    /// the customer visited was store.myshopify.com/products/1.
    /// </summary>
    [JsonPropertyName("landingPageHtml")]
    public string? landingPageHtml { get; set; } = null;

    /// <summary>
    /// Represent actions taken by an app, on behalf of a merchant,
    /// to market Shopify resources such as products, collections, and discounts.
    /// </summary>
    [JsonPropertyName("marketingEvent")]
    public MarketingEvent? marketingEvent { get; set; } = null;

    /// <summary>
    /// The date and time when the customer's session occurred.
    /// </summary>
    [JsonPropertyName("occurredAt")]
    public DateTime? occurredAt { get; set; } = null;

    /// <summary>
    /// Marketing referral code from the link that the customer clicked to visit the store.
    /// Supports the following URL attributes: _ref_, _source_, or _r_.
    /// For example, if the URL is myshopifystore.com/products/slide?ref=j2tj1tn2, then this value is j2tj1tn2.
    /// </summary>
    [JsonPropertyName("referralCode")]
    public string? referralCode { get; set; } = null;

    /// <summary>
    /// Referral information with URLs linked in HTML.
    /// </summary>
    [JsonPropertyName("referralInfoHtml")]
    public string? referralInfoHtml { get; set; } = null;

    /// <summary>
    /// Webpage where the customer clicked a link that sent them to the online store.
    /// For example, _https://randomblog.com/page1_ or _android-app://com.google.android.gm_.
    /// </summary>
    [JsonPropertyName("referrerUrl")]
    public string? referrerUrl { get; set; } = null;

    /// <summary>
    /// Source from which the customer visited the store, such as a platform (Facebook, Google), email, direct,
    /// a website domain, QR code, or unknown.
    /// </summary>
    [JsonPropertyName("source")]
    public string? source { get; set; } = null;

    /// <summary>
    /// Describes the source explicitly for first or last session.
    /// </summary>
    [JsonPropertyName("sourceDescription")]
    public string? sourceDescription { get; set; } = null;

    /// <summary>
    /// Type of marketing tactic.
    /// </summary>
    [JsonPropertyName("sourceType")]
    public MarketingTactic? sourceType { get; set; } = null;

    /// <summary>
    /// A set of UTM parameters gathered from the URL parameters of the referrer.
    /// </summary>
    [JsonPropertyName("utmParameters")]
    public UTMParameters? utmParameters { get; set; } = null;
}