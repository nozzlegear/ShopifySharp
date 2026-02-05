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
/// Return type for `companyContactAssignRoles` mutation.
/// </summary>
public record CompanyContactAssignRolesPayload : IGraphQLObject
{
    /// <summary>
    /// A list of newly created assignments of company contacts to a company location.
    /// </summary>
    [JsonPropertyName("roleAssignments")]
    public ICollection<CompanyContactRoleAssignment>? roleAssignments { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BusinessCustomerUserError>? userErrors { get; set; } = null;
}