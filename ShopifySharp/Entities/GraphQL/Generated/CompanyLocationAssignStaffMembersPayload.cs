#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `companyLocationAssignStaffMembers` mutation.
/// </summary>
public record CompanyLocationAssignStaffMembersPayload : IGraphQLObject
{
    /// <summary>
    /// The list of created staff member assignments.
    /// </summary>
    [JsonPropertyName("companyLocationStaffMemberAssignments")]
    public ICollection<CompanyLocationStaffMemberAssignment>? companyLocationStaffMemberAssignments { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BusinessCustomerUserError>? userErrors { get; set; } = null;
}