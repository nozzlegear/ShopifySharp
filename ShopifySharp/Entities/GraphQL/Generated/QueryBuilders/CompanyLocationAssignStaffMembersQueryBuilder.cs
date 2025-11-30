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

public class CompanyLocationAssignStaffMembersQueryBuilder() : GraphQueryBuilder<CompanyLocationAssignStaffMembersPayload>("query companyLocationAssignStaffMembers")
{
    public CompanyLocationAssignStaffMembersQueryBuilder AddArgumentCompanyLocationId(string? companyLocationId)
    {
        AddArgument("companyLocationId", companyLocationId);
        return this;
    }

    public CompanyLocationAssignStaffMembersQueryBuilder AddArgumentStaffMemberIds(ICollection<string>? staffMemberIds)
    {
        AddArgument("staffMemberIds", staffMemberIds);
        return this;
    }
}