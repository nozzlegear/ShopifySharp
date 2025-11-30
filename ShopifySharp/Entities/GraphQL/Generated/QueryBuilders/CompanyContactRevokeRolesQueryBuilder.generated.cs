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

public class CompanyContactRevokeRolesQueryBuilder() : GraphQueryBuilder<CompanyContactRevokeRolesPayload>("companyContactRevokeRoles"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public CompanyContactRevokeRolesQueryBuilder AddArgumentCompanyContactId(string? companyContactId)
    {
        AddArgument("companyContactId", companyContactId);
        return this;
    }

    public CompanyContactRevokeRolesQueryBuilder AddArgumentRevokeAll(bool? revokeAll)
    {
        AddArgument("revokeAll", revokeAll);
        return this;
    }

    public CompanyContactRevokeRolesQueryBuilder AddArgumentRoleAssignmentIds(ICollection<string>? roleAssignmentIds)
    {
        AddArgument("roleAssignmentIds", roleAssignmentIds);
        return this;
    }
}