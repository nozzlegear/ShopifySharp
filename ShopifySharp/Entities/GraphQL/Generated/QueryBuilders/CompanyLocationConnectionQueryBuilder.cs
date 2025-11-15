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

public class CompanyLocationConnectionQueryBuilder() : GraphQueryBuilder<CompanyLocationConnection>("query companyLocationConnection")
{
    public CompanyLocationConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public CompanyLocationConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public CompanyLocationConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}