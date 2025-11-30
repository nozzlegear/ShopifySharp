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

public class CompanyContactRevokeRolesPayloadQueryBuilder() : GraphQueryBuilder<CompanyContactRevokeRolesPayload>("query companyContactRevokeRolesPayload")
{
    public CompanyContactRevokeRolesPayloadQueryBuilder AddFieldRevokedRoleAssignmentIds()
    {
        AddField("revokedRoleAssignmentIds");
        return this;
    }

    public CompanyContactRevokeRolesPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}