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

public class FulfillmentEventConnectionQueryBuilder() : GraphQueryBuilder<FulfillmentEventConnection>("query fulfillmentEventConnection")
{
    public FulfillmentEventConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public FulfillmentEventConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public FulfillmentEventConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}