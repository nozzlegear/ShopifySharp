#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `companyContactRevokeRoles` mutation.
/// </summary>
public record CompanyContactRevokeRolesPayload : IGraphQLObject
{
    /// <summary>
    /// A list of role assignment IDs that were removed from the company contact.
    /// </summary>
    [JsonPropertyName("revokedRoleAssignmentIds")]
    public ICollection<string>? revokedRoleAssignmentIds { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BusinessCustomerUserError>? userErrors { get; set; } = null;
}