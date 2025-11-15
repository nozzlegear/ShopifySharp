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

public class StoreCreditAccountConnectionQueryBuilder() : GraphQueryBuilder<StoreCreditAccountConnection>("query storeCreditAccountConnection")
{
    public StoreCreditAccountConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public StoreCreditAccountConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public StoreCreditAccountConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}