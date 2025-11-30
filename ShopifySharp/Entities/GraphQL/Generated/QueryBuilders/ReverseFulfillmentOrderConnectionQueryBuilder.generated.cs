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

public class ReverseFulfillmentOrderConnectionQueryBuilder() : GraphQueryBuilder<ReverseFulfillmentOrderConnection>("reverseFulfillmentOrderConnection")
{
    public ReverseFulfillmentOrderConnectionQueryBuilder AddFieldEdges(Func<ReverseFulfillmentOrderEdgeQueryBuilder, ReverseFulfillmentOrderEdgeQueryBuilder> build)
    {
        AddField<ReverseFulfillmentOrderEdge, ReverseFulfillmentOrderEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ReverseFulfillmentOrderConnectionQueryBuilder AddFieldNodes(Func<ReverseFulfillmentOrderQueryBuilder, ReverseFulfillmentOrderQueryBuilder> build)
    {
        AddField<ReverseFulfillmentOrder, ReverseFulfillmentOrderQueryBuilder>("nodes", build);
        return this;
    }

    public ReverseFulfillmentOrderConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}