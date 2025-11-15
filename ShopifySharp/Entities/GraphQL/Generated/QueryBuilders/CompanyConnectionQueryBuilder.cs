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

public class CompanyConnectionQueryBuilder() : GraphQueryBuilder<CompanyConnection>("query companyConnection")
{
    public CompanyConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public CompanyConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public CompanyConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}