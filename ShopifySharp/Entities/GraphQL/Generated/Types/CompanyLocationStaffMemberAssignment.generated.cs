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
/// A representation of store's staff member who is assigned to a [company
/// location](https://shopify.dev/api/admin-graphql/latest/objects/CompanyLocation)
/// of the shop. The staff member's actions will be limited to objects associated
/// with the assigned company location.
/// </summary>
public record CompanyLocationStaffMemberAssignment : IGraphQLObject, INode
{
    /// <summary>
    /// The company location the staff member is assigned to.
    /// </summary>
    [JsonPropertyName("companyLocation")]
    public CompanyLocation? companyLocation { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Represents the data of a staff member who's assigned to a company location.
    /// </summary>
    [JsonPropertyName("staffMember")]
    public StaffMember? staffMember { get; set; } = null;
}