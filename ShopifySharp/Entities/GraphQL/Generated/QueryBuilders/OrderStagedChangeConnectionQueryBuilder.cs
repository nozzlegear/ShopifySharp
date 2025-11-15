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

public class OrderStagedChangeConnectionQueryBuilder() : GraphQueryBuilder<OrderStagedChangeConnection>("query orderStagedChangeConnection")
{
    public OrderStagedChangeConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public OrderStagedChangeConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public OrderStagedChangeConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}