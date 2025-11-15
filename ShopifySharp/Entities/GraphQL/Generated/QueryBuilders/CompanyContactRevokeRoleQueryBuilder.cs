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

public class CompanyContactRevokeRoleQueryBuilder() : GraphQueryBuilder<CompanyContactRevokeRolePayload>("query companyContactRevokeRole")
{
    public CompanyContactRevokeRoleQueryBuilder AddArgumentCompanyContactId(string? companyContactId)
    {
        AddArgument("companyContactId", companyContactId);
        return this;
    }

    public CompanyContactRevokeRoleQueryBuilder AddArgumentCompanyContactRoleAssignmentId(string? companyContactRoleAssignmentId)
    {
        AddArgument("companyContactRoleAssignmentId", companyContactRoleAssignmentId);
        return this;
    }
}