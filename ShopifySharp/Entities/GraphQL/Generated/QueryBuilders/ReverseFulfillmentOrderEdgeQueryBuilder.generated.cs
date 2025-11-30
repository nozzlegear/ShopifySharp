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

public class ReverseFulfillmentOrderEdgeQueryBuilder() : GraphQueryBuilder<ReverseFulfillmentOrderEdge>("reverseFulfillmentOrderEdge")
{
    public ReverseFulfillmentOrderEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ReverseFulfillmentOrderEdgeQueryBuilder AddFieldNode(Func<ReverseFulfillmentOrderQueryBuilder, ReverseFulfillmentOrderQueryBuilder> build)
    {
        AddField<ReverseFulfillmentOrder, ReverseFulfillmentOrderQueryBuilder>("node", build);
        return this;
    }
}