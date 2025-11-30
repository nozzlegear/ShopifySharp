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

public class CompanyContactConnectionQueryBuilder() : GraphQueryBuilder<CompanyContactConnection>("query companyContactConnection")
{
    public CompanyContactConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public CompanyContactConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public CompanyContactConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}