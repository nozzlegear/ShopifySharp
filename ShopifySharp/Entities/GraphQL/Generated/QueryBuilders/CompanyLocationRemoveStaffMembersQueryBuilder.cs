#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class CompanyLocationRemoveStaffMembersQueryBuilder() : GraphQueryBuilder<CompanyLocationRemoveStaffMembersPayload>("query companyLocationRemoveStaffMembers")
{
    public CompanyLocationRemoveStaffMembersQueryBuilder AddArgumentCompanyLocationStaffMemberAssignmentIds(ICollection<string>? companyLocationStaffMemberAssignmentIds)
    {
        AddArgument("companyLocationStaffMemberAssignmentIds", companyLocationStaffMemberAssignmentIds);
        return this;
    }
}