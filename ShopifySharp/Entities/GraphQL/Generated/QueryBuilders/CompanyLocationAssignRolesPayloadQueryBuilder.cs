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

public class CompanyLocationAssignRolesPayloadQueryBuilder() : GraphQueryBuilder<CompanyLocationAssignRolesPayload>("query companyLocationAssignRolesPayload")
{
    public CompanyLocationAssignRolesPayloadQueryBuilder AddFieldRoleAssignments()
    {
        AddField("roleAssignments");
        return this;
    }

    public CompanyLocationAssignRolesPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}