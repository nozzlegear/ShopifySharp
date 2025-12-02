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

public class FulfillmentOrderLineItemConnectionQueryBuilder() : GraphQueryBuilder<FulfillmentOrderLineItemConnection>("fulfillmentOrderLineItemConnection")
{
    public FulfillmentOrderLineItemConnectionQueryBuilder AddFieldEdges(Func<FulfillmentOrderLineItemEdgeQueryBuilder, FulfillmentOrderLineItemEdgeQueryBuilder> build)
    {
        AddField<FulfillmentOrderLineItemEdge, FulfillmentOrderLineItemEdgeQueryBuilder>("edges", build);
        return this;
    }

    public FulfillmentOrderLineItemConnectionQueryBuilder AddFieldNodes(Func<FulfillmentOrderLineItemQueryBuilder, FulfillmentOrderLineItemQueryBuilder> build)
    {
        AddField<FulfillmentOrderLineItem, FulfillmentOrderLineItemQueryBuilder>("nodes", build);
        return this;
    }

    public FulfillmentOrderLineItemConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}