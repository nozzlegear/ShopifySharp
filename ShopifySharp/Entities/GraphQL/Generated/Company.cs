#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents information about a company which is also a customer of the shop.
/// </summary>
public record Company : IGraphQLUnionCase, IGraphQLObject, ICommentEventSubject, IHasEvents, IHasMetafieldDefinitions, IHasMetafields, INavigable, INode
{
    /// <summary>
    /// The number of contacts that belong to the company.
    /// </summary>
    [JsonPropertyName("contactCount")]
    [Obsolete("Use `contactsCount` instead.")]
    public int? contactCount { get; set; } = null;

    /// <summary>
    /// The list of roles for the company contacts.
    /// </summary>
    [JsonPropertyName("contactRoles")]
    public CompanyContactRoleConnection? contactRoles { get; set; } = null;

    /// <summary>
    /// The list of contacts in the company.
    /// </summary>
    [JsonPropertyName("contacts")]
    public CompanyContactConnection? contacts { get; set; } = null;

    /// <summary>
    /// The number of contacts that belong to the company.
    /// </summary>
    [JsonPropertyName("contactsCount")]
    public Count? contactsCount { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) at which the company was created in Shopify.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) at which the company became the customer.
    /// </summary>
    [JsonPropertyName("customerSince")]
    public DateTime? customerSince { get; set; } = null;

    /// <summary>
    /// A default [cursor](https://shopify.dev/api/usage/pagination-graphql) that
    /// returns the single next record, sorted ascending by ID.
    /// </summary>
    [JsonPropertyName("defaultCursor")]
    public string? defaultCursor { get; set; } = null;

    /// <summary>
    /// The role proposed by default for a contact at the company.
    /// </summary>
    [JsonPropertyName("defaultRole")]
    public CompanyContactRole? defaultRole { get; set; } = null;

    /// <summary>
    /// The list of the company's draft orders.
    /// </summary>
    [JsonPropertyName("draftOrders")]
    public DraftOrderConnection? draftOrders { get; set; } = null;

    /// <summary>
    /// The paginated list of events associated with the host subject.
    /// </summary>
    [JsonPropertyName("events")]
    public EventConnection? events { get; set; } = null;

    /// <summary>
    /// A unique externally-supplied ID for the company.
    /// </summary>
    [JsonPropertyName("externalId")]
    public string? externalId { get; set; } = null;

    /// <summary>
    /// Whether the merchant added a timeline comment to the company.
    /// </summary>
    [JsonPropertyName("hasTimelineComment")]
    public bool? hasTimelineComment { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The lifetime duration of the company, since it became a customer of the shop. Examples: `2 days`, `3 months`, `1 year`.
    /// </summary>
    [JsonPropertyName("lifetimeDuration")]
    public string? lifetimeDuration { get; set; } = null;

    /// <summary>
    /// The list of locations in the company.
    /// </summary>
    [JsonPropertyName("locations")]
    public CompanyLocationConnection? locations { get; set; } = null;

    /// <summary>
    /// The number of locations that belong to the company.
    /// </summary>
    [JsonPropertyName("locationsCount")]
    public Count? locationsCount { get; set; } = null;

    /// <summary>
    /// The main contact for the company.
    /// </summary>
    [JsonPropertyName("mainContact")]
    public CompanyContact? mainContact { get; set; } = null;

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
    /// The name of the company.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// A note about the company.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The list of the company's orders.
    /// </summary>
    [JsonPropertyName("orders")]
    public OrderConnection? orders { get; set; } = null;

    /// <summary>
    /// The total number of orders placed for this company, across all its locations.
    /// </summary>
    [JsonPropertyName("ordersCount")]
    public Count? ordersCount { get; set; } = null;

    /// <summary>
    /// The total amount spent by this company, across all its locations.
    /// </summary>
    [JsonPropertyName("totalSpent")]
    public MoneyV2? totalSpent { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) at which the company was last modified.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? updatedAt { get; set; } = null;
}