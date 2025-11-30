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

public class AppSubscriptionConnectionQueryBuilder() : GraphQueryBuilder<AppSubscriptionConnection>("query appSubscriptionConnection")
{
    public AppSubscriptionConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public AppSubscriptionConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public AppSubscriptionConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}