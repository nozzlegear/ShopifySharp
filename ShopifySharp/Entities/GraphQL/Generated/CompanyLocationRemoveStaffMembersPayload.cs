#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `companyLocationRemoveStaffMembers` mutation.
/// </summary>
public record CompanyLocationRemoveStaffMembersPayload : IGraphQLObject
{
    /// <summary>
    /// The list of IDs of the deleted staff member assignment.
    /// </summary>
    [JsonPropertyName("deletedCompanyLocationStaffMemberAssignmentIds")]
    public ICollection<string>? deletedCompanyLocationStaffMemberAssignmentIds { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BusinessCustomerUserError>? userErrors { get; set; } = null;
}