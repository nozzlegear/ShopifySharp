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

public class AppPurchaseOneTimeConnectionQueryBuilder() : GraphQueryBuilder<AppPurchaseOneTimeConnection>("query appPurchaseOneTimeConnection")
{
    public AppPurchaseOneTimeConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public AppPurchaseOneTimeConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public AppPurchaseOneTimeConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}