#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `companyContactRevokeRole` mutation.
/// </summary>
public record CompanyContactRevokeRolePayload : IGraphQLObject
{
    /// <summary>
    /// The role assignment that was revoked.
    /// </summary>
    [JsonPropertyName("revokedCompanyContactRoleAssignmentId")]
    public string? revokedCompanyContactRoleAssignmentId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BusinessCustomerUserError>? userErrors { get; set; } = null;
}