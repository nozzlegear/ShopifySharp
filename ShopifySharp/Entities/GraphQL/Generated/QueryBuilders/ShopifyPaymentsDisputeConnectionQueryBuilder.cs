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

public class ShopifyPaymentsDisputeConnectionQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsDisputeConnection>("query shopifyPaymentsDisputeConnection")
{
    public ShopifyPaymentsDisputeConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public ShopifyPaymentsDisputeConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public ShopifyPaymentsDisputeConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}