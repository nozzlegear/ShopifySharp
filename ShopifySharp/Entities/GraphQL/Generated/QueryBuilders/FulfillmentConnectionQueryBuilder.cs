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

public class FulfillmentConnectionQueryBuilder() : GraphQueryBuilder<FulfillmentConnection>("query fulfillmentConnection")
{
    public FulfillmentConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public FulfillmentConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public FulfillmentConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}