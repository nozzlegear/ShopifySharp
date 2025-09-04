#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A location or branch of a [company that's a
/// customer](https://shopify.dev/api/admin-graphql/latest/objects/company) of the
/// shop. Configuration of B2B relationship, for example prices lists and checkout
/// settings, may be done for a location.
/// </summary>
public record CompanyLocation : IGraphQLUnionCase, IGraphQLObject, ICommentEventSubject, IHasEvents, IHasMetafieldDefinitions, IHasMetafields, INavigable, INode
{
    /// <summary>
    /// The address used as billing address for the location.
    /// </summary>
    [JsonPropertyName("billingAddress")]
    public CompanyAddress? billingAddress { get; set; } = null;

    /// <summary>
    /// The configuration for the buyer's B2B checkout.
    /// </summary>
    [JsonPropertyName("buyerExperienceConfiguration")]
    public BuyerExperienceConfiguration? buyerExperienceConfiguration { get; set; } = null;

    /// <summary>
    /// The list of catalogs associated with the company location.
    /// </summary>
    [JsonPropertyName("catalogs")]
    public CatalogConnection? catalogs { get; set; } = null;

    /// <summary>
    /// The number of catalogs associated with the company location. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("catalogsCount")]
    public Count? catalogsCount { get; set; } = null;

    /// <summary>
    /// The company that the company location belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public Company? company { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601))
    /// at which the company location was created in Shopify.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The location's currency based on the shipping address. If the shipping address
    /// is empty, then the value is the shop's primary market.
    /// </summary>
    [JsonPropertyName("currency")]
    public CurrencyCode? currency { get; set; } = null;

    /// <summary>
    /// A default [cursor](https://shopify.dev/api/usage/pagination-graphql) that
    /// returns the single next record, sorted ascending by ID.
    /// </summary>
    [JsonPropertyName("defaultCursor")]
    public string? defaultCursor { get; set; } = null;

    /// <summary>
    /// The list of draft orders for the company location.
    /// </summary>
    [JsonPropertyName("draftOrders")]
    public DraftOrderConnection? draftOrders { get; set; } = null;

    /// <summary>
    /// The paginated list of events associated with the host subject.
    /// </summary>
    [JsonPropertyName("events")]
    public EventConnection? events { get; set; } = null;

    /// <summary>
    /// A unique externally-supplied ID for the company location.
    /// </summary>
    [JsonPropertyName("externalId")]
    public string? externalId { get; set; } = null;

    /// <summary>
    /// Whether the merchant added a timeline comment to the company location.
    /// </summary>
    [JsonPropertyName("hasTimelineComment")]
    public bool? hasTimelineComment { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether the company location is assigned a specific catalog.
    /// </summary>
    [JsonPropertyName("inCatalog")]
    public bool? inCatalog { get; set; } = null;

    /// <summary>
    /// The preferred locale of the company location.
    /// </summary>
    [JsonPropertyName("locale")]
    public string? locale { get; set; } = null;

    /// <summary>
    /// The market that includes the location's shipping address. If the shipping
    /// address is empty, then the value is the shop's primary market.
    /// </summary>
    [JsonPropertyName("market")]
    [Obsolete("This `market` field will be removed in a future version of the API.")]
    public Market? market { get; set; } = null;

    /// <summary>
    /// A [custom field](https://shopify.dev/docs/apps/build/custom-data),
    /// including its `namespace` and `key`, that's associated with a Shopify resource
    /// for the purposes of adding and storing additional information.
    /// </summary>
    [JsonPropertyName("metafield")]
    public Metafield? metafield { get; set; } = null;

    /// <summary>
    /// List of metafield definitions.
    /// </summary>
    [JsonPropertyName("metafieldDefinitions")]
    [Obsolete("This field will be removed in a future version. Use `QueryRoot.metafieldDefinitions` instead.")]
    public MetafieldDefinitionConnection? metafieldDefinitions { get; set; } = null;

    /// <summary>
    /// A list of [custom fields](https://shopify.dev/docs/apps/build/custom-data)
    /// that a merchant associates with a Shopify resource.
    /// </summary>
    [JsonPropertyName("metafields")]
    public MetafieldConnection? metafields { get; set; } = null;

    /// <summary>
    /// The name of the company location.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// A note about the company location.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The total number of orders placed for the location.
    /// </summary>
    [JsonPropertyName("orderCount")]
    [Obsolete("Use `ordersCount` instead.")]
    public int? orderCount { get; set; } = null;

    /// <summary>
    /// The list of orders for the company location.
    /// </summary>
    [JsonPropertyName("orders")]
    public OrderConnection? orders { get; set; } = null;

    /// <summary>
    /// The total number of orders placed for the location.
    /// </summary>
    [JsonPropertyName("ordersCount")]
    public Count? ordersCount { get; set; } = null;

    /// <summary>
    /// The phone number of the company location.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// The list of roles assigned to the company location.
    /// </summary>
    [JsonPropertyName("roleAssignments")]
    public CompanyContactRoleAssignmentConnection? roleAssignments { get; set; } = null;

    /// <summary>
    /// The address used as shipping address for the location.
    /// </summary>
    [JsonPropertyName("shippingAddress")]
    public CompanyAddress? shippingAddress { get; set; } = null;

    /// <summary>
    /// The list of staff members assigned to the company location.
    /// </summary>
    [JsonPropertyName("staffMemberAssignments")]
    public CompanyLocationStaffMemberAssignmentConnection? staffMemberAssignments { get; set; } = null;

    /// <summary>
    /// The list of tax exemptions applied to the location.
    /// </summary>
    [JsonPropertyName("taxExemptions")]
    [Obsolete("Use `taxSettings` instead.")]
    public ICollection<TaxExemption>? taxExemptions { get; set; } = null;

    /// <summary>
    /// The tax registration ID for the company location.
    /// </summary>
    [JsonPropertyName("taxRegistrationId")]
    [Obsolete("Use `taxSettings` instead.")]
    public string? taxRegistrationId { get; set; } = null;

    /// <summary>
    /// The tax settings for the company location.
    /// </summary>
    [JsonPropertyName("taxSettings")]
    public CompanyLocationTaxSettings? taxSettings { get; set; } = null;

    /// <summary>
    /// The total amount spent by the location.
    /// </summary>
    [JsonPropertyName("totalSpent")]
    public MoneyV2? totalSpent { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601))
    /// at which the company location was last modified.
    /// </summary>
    [JsonPropertyName("updatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? updatedAt { get; set; } = null;
}