#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `companyContactAssignRole` mutation.
/// </summary>
public record CompanyContactAssignRolePayload : IGraphQLObject
{
    /// <summary>
    /// The company contact role assignment.
    /// </summary>
    [JsonPropertyName("companyContactRoleAssignment")]
    public CompanyContactRoleAssignment? companyContactRoleAssignment { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BusinessCustomerUserError>? userErrors { get; set; } = null;
}