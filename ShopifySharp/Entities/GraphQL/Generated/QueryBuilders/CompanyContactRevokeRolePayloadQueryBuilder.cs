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

public class CompanyContactRevokeRolePayloadQueryBuilder() : GraphQueryBuilder<CompanyContactRevokeRolePayload>("query companyContactRevokeRolePayload")
{
    public CompanyContactRevokeRolePayloadQueryBuilder AddFieldRevokedCompanyContactRoleAssignmentId()
    {
        AddField("revokedCompanyContactRoleAssignmentId");
        return this;
    }

    public CompanyContactRevokeRolePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}