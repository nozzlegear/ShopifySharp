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

public class PageConnectionQueryBuilder() : GraphQueryBuilder<PageConnection>("query pageConnection")
{
    public PageConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public PageConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public PageConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}