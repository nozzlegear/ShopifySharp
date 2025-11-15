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

public class CompanyLocationAssignRolesQueryBuilder() : GraphQueryBuilder<CompanyLocationAssignRolesPayload>("query companyLocationAssignRoles")
{
    public CompanyLocationAssignRolesQueryBuilder AddArgumentCompanyLocationId(string? companyLocationId)
    {
        AddArgument("companyLocationId", companyLocationId);
        return this;
    }

    public CompanyLocationAssignRolesQueryBuilder AddArgumentRolesToAssign(ICollection<CompanyLocationRoleAssign>? rolesToAssign)
    {
        AddArgument("rolesToAssign", rolesToAssign);
        return this;
    }
}