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

public class OrderTransactionConnectionQueryBuilder() : GraphQueryBuilder<OrderTransactionConnection>("query orderTransactionConnection")
{
    public OrderTransactionConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public OrderTransactionConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public OrderTransactionConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}