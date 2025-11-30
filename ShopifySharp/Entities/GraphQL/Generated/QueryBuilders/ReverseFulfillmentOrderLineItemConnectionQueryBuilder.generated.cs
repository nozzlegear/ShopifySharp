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

public class ReverseFulfillmentOrderLineItemConnectionQueryBuilder() : GraphQueryBuilder<ReverseFulfillmentOrderLineItemConnection>("reverseFulfillmentOrderLineItemConnection")
{
    public ReverseFulfillmentOrderLineItemConnectionQueryBuilder AddFieldEdges(Func<ReverseFulfillmentOrderLineItemEdgeQueryBuilder, ReverseFulfillmentOrderLineItemEdgeQueryBuilder> build)
    {
        AddField<ReverseFulfillmentOrderLineItemEdge, ReverseFulfillmentOrderLineItemEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ReverseFulfillmentOrderLineItemConnectionQueryBuilder AddFieldNodes(Func<ReverseFulfillmentOrderLineItemQueryBuilder, ReverseFulfillmentOrderLineItemQueryBuilder> build)
    {
        AddField<ReverseFulfillmentOrderLineItem, ReverseFulfillmentOrderLineItemQueryBuilder>("nodes", build);
        return this;
    }

    public ReverseFulfillmentOrderLineItemConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}