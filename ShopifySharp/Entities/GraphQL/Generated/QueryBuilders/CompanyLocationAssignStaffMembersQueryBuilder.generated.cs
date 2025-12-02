#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class CompanyLocationAssignStaffMembersQueryBuilder() : GraphQueryBuilder<CompanyLocationAssignStaffMembersPayload>("companyLocationAssignStaffMembers"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

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