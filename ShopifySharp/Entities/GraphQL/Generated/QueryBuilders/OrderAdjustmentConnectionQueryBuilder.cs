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

public class OrderAdjustmentConnectionQueryBuilder() : GraphQueryBuilder<OrderAdjustmentConnection>("query orderAdjustmentConnection")
{
    public OrderAdjustmentConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public OrderAdjustmentConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public OrderAdjustmentConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}