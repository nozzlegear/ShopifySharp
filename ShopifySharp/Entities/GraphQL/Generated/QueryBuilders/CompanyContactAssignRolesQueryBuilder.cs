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

public class CompanyContactAssignRolesQueryBuilder() : GraphQueryBuilder<CompanyContactAssignRolesPayload>("query companyContactAssignRoles")
{
    public CompanyContactAssignRolesQueryBuilder AddArgumentCompanyContactId(string? companyContactId)
    {
        AddArgument("companyContactId", companyContactId);
        return this;
    }

    public CompanyContactAssignRolesQueryBuilder AddArgumentRolesToAssign(ICollection<CompanyContactRoleAssign>? rolesToAssign)
    {
        AddArgument("rolesToAssign", rolesToAssign);
        return this;
    }
}