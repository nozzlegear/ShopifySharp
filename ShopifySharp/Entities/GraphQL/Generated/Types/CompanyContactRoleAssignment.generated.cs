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
/// The CompanyContactRoleAssignment describes the company and location associated to a company contact's role.
/// </summary>
public record CompanyContactRoleAssignment : IGraphQLObject, INode
{
    /// <summary>
    /// The company this role assignment belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public Company? company { get; set; } = null;

    /// <summary>
    /// The company contact for whom this role is assigned.
    /// </summary>
    [JsonPropertyName("companyContact")]
    public CompanyContact? companyContact { get; set; } = null;

    /// <summary>
    /// The company location to which the role is assigned.
    /// </summary>
    [JsonPropertyName("companyLocation")]
    public CompanyLocation? companyLocation { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) when the assignment record was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The role that's assigned to the company contact.
    /// </summary>
    [JsonPropertyName("role")]
    public CompanyContactRole? role { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) when the assignment record was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;
}