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

public class ShopifyPaymentsPayoutConnectionQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsPayoutConnection>("query shopifyPaymentsPayoutConnection")
{
    public ShopifyPaymentsPayoutConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public ShopifyPaymentsPayoutConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public ShopifyPaymentsPayoutConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}