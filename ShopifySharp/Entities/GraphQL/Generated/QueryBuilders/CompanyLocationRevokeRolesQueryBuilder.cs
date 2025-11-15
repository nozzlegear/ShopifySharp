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

public class CompanyLocationRevokeRolesQueryBuilder() : GraphQueryBuilder<CompanyLocationRevokeRolesPayload>("query companyLocationRevokeRoles")
{
    public CompanyLocationRevokeRolesQueryBuilder AddArgumentCompanyLocationId(string? companyLocationId)
    {
        AddArgument("companyLocationId", companyLocationId);
        return this;
    }

    public CompanyLocationRevokeRolesQueryBuilder AddArgumentRolesToRevoke(ICollection<string>? rolesToRevoke)
    {
        AddArgument("rolesToRevoke", rolesToRevoke);
        return this;
    }
}