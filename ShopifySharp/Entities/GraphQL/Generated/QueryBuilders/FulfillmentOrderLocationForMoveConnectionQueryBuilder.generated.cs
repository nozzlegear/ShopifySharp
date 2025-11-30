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

public class FulfillmentOrderLocationForMoveConnectionQueryBuilder() : GraphQueryBuilder<FulfillmentOrderLocationForMoveConnection>("fulfillmentOrderLocationForMoveConnection")
{
    public FulfillmentOrderLocationForMoveConnectionQueryBuilder AddFieldEdges(Func<FulfillmentOrderLocationForMoveEdgeQueryBuilder, FulfillmentOrderLocationForMoveEdgeQueryBuilder> build)
    {
        AddField<FulfillmentOrderLocationForMoveEdge, FulfillmentOrderLocationForMoveEdgeQueryBuilder>("edges", build);
        return this;
    }

    public FulfillmentOrderLocationForMoveConnectionQueryBuilder AddFieldNodes(Func<FulfillmentOrderLocationForMoveQueryBuilder, FulfillmentOrderLocationForMoveQueryBuilder> build)
    {
        AddField<FulfillmentOrderLocationForMove, FulfillmentOrderLocationForMoveQueryBuilder>("nodes", build);
        return this;
    }

    public FulfillmentOrderLocationForMoveConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}