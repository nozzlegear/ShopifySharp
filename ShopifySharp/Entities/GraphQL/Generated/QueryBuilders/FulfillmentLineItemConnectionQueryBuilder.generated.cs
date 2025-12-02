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

public class FulfillmentLineItemConnectionQueryBuilder() : GraphQueryBuilder<FulfillmentLineItemConnection>("fulfillmentLineItemConnection")
{
    public FulfillmentLineItemConnectionQueryBuilder AddFieldEdges(Func<FulfillmentLineItemEdgeQueryBuilder, FulfillmentLineItemEdgeQueryBuilder> build)
    {
        AddField<FulfillmentLineItemEdge, FulfillmentLineItemEdgeQueryBuilder>("edges", build);
        return this;
    }

    public FulfillmentLineItemConnectionQueryBuilder AddFieldNodes(Func<FulfillmentLineItemQueryBuilder, FulfillmentLineItemQueryBuilder> build)
    {
        AddField<FulfillmentLineItem, FulfillmentLineItemQueryBuilder>("nodes", build);
        return this;
    }

    public FulfillmentLineItemConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}