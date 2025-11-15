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

public class CompanyContactRoleConnectionQueryBuilder() : GraphQueryBuilder<CompanyContactRoleConnection>("query companyContactRoleConnection")
{
    public CompanyContactRoleConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public CompanyContactRoleConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public CompanyContactRoleConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}