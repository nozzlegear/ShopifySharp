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

public class CompanyContactAssignRolePayloadQueryBuilder() : GraphQueryBuilder<CompanyContactAssignRolePayload>("query companyContactAssignRolePayload")
{
    public CompanyContactAssignRolePayloadQueryBuilder AddFieldCompanyContactRoleAssignment()
    {
        AddField("companyContactRoleAssignment");
        return this;
    }

    public CompanyContactAssignRolePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}