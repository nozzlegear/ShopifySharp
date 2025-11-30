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

public class FulfillmentOrderLocationForMoveEdgeQueryBuilder() : GraphQueryBuilder<FulfillmentOrderLocationForMoveEdge>("fulfillmentOrderLocationForMoveEdge")
{
    public FulfillmentOrderLocationForMoveEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public FulfillmentOrderLocationForMoveEdgeQueryBuilder AddFieldNode(Func<FulfillmentOrderLocationForMoveQueryBuilder, FulfillmentOrderLocationForMoveQueryBuilder> build)
    {
        AddField<FulfillmentOrderLocationForMove, FulfillmentOrderLocationForMoveQueryBuilder>("node", build);
        return this;
    }
}