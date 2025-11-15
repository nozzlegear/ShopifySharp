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

public class ReturnConnectionQueryBuilder() : GraphQueryBuilder<ReturnConnection>("query returnConnection")
{
    public ReturnConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public ReturnConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public ReturnConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}