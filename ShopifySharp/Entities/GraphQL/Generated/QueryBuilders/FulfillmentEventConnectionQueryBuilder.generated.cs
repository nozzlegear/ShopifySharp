#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class FulfillmentEventConnectionQueryBuilder() : GraphQueryBuilder<FulfillmentEventConnection>("fulfillmentEventConnection")
{
    public FulfillmentEventConnectionQueryBuilder AddFieldEdges(Func<FulfillmentEventEdgeQueryBuilder, FulfillmentEventEdgeQueryBuilder> build)
    {
        AddField<FulfillmentEventEdge, FulfillmentEventEdgeQueryBuilder>("edges", build);
        return this;
    }

    public FulfillmentEventConnectionQueryBuilder AddFieldNodes(Func<FulfillmentEventQueryBuilder, FulfillmentEventQueryBuilder> build)
    {
        AddField<FulfillmentEvent, FulfillmentEventQueryBuilder>("nodes", build);
        return this;
    }

    public FulfillmentEventConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}