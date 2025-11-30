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

public class ReturnableFulfillmentConnectionQueryBuilder() : GraphQueryBuilder<ReturnableFulfillmentConnection>("returnableFulfillmentConnection")
{
    public ReturnableFulfillmentConnectionQueryBuilder AddFieldEdges(Func<ReturnableFulfillmentEdgeQueryBuilder, ReturnableFulfillmentEdgeQueryBuilder> build)
    {
        AddField<ReturnableFulfillmentEdge, ReturnableFulfillmentEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ReturnableFulfillmentConnectionQueryBuilder AddFieldNodes(Func<ReturnableFulfillmentQueryBuilder, ReturnableFulfillmentQueryBuilder> build)
    {
        AddField<ReturnableFulfillment, ReturnableFulfillmentQueryBuilder>("nodes", build);
        return this;
    }

    public ReturnableFulfillmentConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}