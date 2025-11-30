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

public class FulfillmentConnectionQueryBuilder() : GraphQueryBuilder<FulfillmentConnection>("fulfillmentConnection")
{
    public FulfillmentConnectionQueryBuilder AddFieldEdges(Func<FulfillmentEdgeQueryBuilder, FulfillmentEdgeQueryBuilder> build)
    {
        AddField<FulfillmentEdge, FulfillmentEdgeQueryBuilder>("edges", build);
        return this;
    }

    public FulfillmentConnectionQueryBuilder AddFieldNodes(Func<FulfillmentQueryBuilder, FulfillmentQueryBuilder> build)
    {
        AddField<Fulfillment, FulfillmentQueryBuilder>("nodes", build);
        return this;
    }

    public FulfillmentConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}