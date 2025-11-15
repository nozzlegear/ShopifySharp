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

public class OrderConnectionQueryBuilder() : GraphQueryBuilder<OrderConnection>("query orderConnection")
{
    public OrderConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public OrderConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public OrderConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}