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

public class ReturnableFulfillmentLineItemConnectionQueryBuilder() : GraphQueryBuilder<ReturnableFulfillmentLineItemConnection>("returnableFulfillmentLineItemConnection")
{
    public ReturnableFulfillmentLineItemConnectionQueryBuilder AddFieldEdges(Func<ReturnableFulfillmentLineItemEdgeQueryBuilder, ReturnableFulfillmentLineItemEdgeQueryBuilder> build)
    {
        AddField<ReturnableFulfillmentLineItemEdge, ReturnableFulfillmentLineItemEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ReturnableFulfillmentLineItemConnectionQueryBuilder AddFieldNodes(Func<ReturnableFulfillmentLineItemQueryBuilder, ReturnableFulfillmentLineItemQueryBuilder> build)
    {
        AddField<ReturnableFulfillmentLineItem, ReturnableFulfillmentLineItemQueryBuilder>("nodes", build);
        return this;
    }

    public ReturnableFulfillmentLineItemConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}