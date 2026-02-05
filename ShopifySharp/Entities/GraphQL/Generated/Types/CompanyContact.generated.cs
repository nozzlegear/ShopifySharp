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
/// A person who acts on behalf of a
/// [`Company`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Company)
/// to make B2B purchases. Company contacts are associated with
/// [`Customer`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Customer)
/// accounts and can place orders on behalf of their company.
/// Each contact can be assigned to one or more [`CompanyLocation`](https://shopify.dev/docs/api/admin-graphql/latest/objects/CompanyLocation)
/// objects with specific roles that determine their permissions and access to
/// catalogs, pricing, and payment terms configured for those locations.
/// </summary>
public record CompanyContact : IGraphQLObject, INode
{
    /// <summary>
    /// The company to which the contact belongs.
    /// </summary>
    [JsonPropertyName("company")]
    public Company? company { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601))
    /// at which the company contact was created at Shopify.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// The customer associated to this contact.
    /// </summary>
    [JsonPropertyName("customer")]
    public Customer? customer { get; set; } = null;

    /// <summary>
    /// The list of draft orders for the company contact.
    /// </summary>
    [JsonPropertyName("draftOrders")]
    public DraftOrderConnection? draftOrders { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether the contact is the main contact of the company.
    /// </summary>
    [JsonPropertyName("isMainContact")]
    public bool? isMainContact { get; set; } = null;

    /// <summary>
    /// The lifetime duration of the company contact, since its creation date on
    /// Shopify. Examples: `1 year`, `2 months`, `3 days`.
    /// </summary>
    [JsonPropertyName("lifetimeDuration")]
    public string? lifetimeDuration { get; set; } = null;

    /// <summary>
    /// The company contact's locale (language).
    /// </summary>
    [JsonPropertyName("locale")]
    public string? locale { get; set; } = null;

    /// <summary>
    /// The list of orders for the company contact.
    /// </summary>
    [JsonPropertyName("orders")]
    public OrderConnection? orders { get; set; } = null;

    /// <summary>
    /// The list of roles assigned to this company contact.
    /// </summary>
    [JsonPropertyName("roleAssignments")]
    public CompanyContactRoleAssignmentConnection? roleAssignments { get; set; } = null;

    /// <summary>
    /// The company contact's job title.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601))
    /// at which the company contact was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;
}