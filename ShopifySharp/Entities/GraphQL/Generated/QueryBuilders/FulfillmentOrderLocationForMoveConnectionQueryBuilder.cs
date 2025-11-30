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

public class FulfillmentOrderLocationForMoveConnectionQueryBuilder() : GraphQueryBuilder<FulfillmentOrderLocationForMoveConnection>("query fulfillmentOrderLocationForMoveConnection")
{
    public FulfillmentOrderLocationForMoveConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public FulfillmentOrderLocationForMoveConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public FulfillmentOrderLocationForMoveConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}