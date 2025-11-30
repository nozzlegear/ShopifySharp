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

public class MarketConnectionQueryBuilder() : GraphQueryBuilder<MarketConnection>("marketConnection")
{
    public MarketConnectionQueryBuilder AddFieldEdges(Func<MarketEdgeQueryBuilder, MarketEdgeQueryBuilder> build)
    {
        AddField<MarketEdge, MarketEdgeQueryBuilder>("edges", build);
        return this;
    }

    public MarketConnectionQueryBuilder AddFieldNodes(Func<MarketQueryBuilder, MarketQueryBuilder> build)
    {
        AddField<Market, MarketQueryBuilder>("nodes", build);
        return this;
    }

    public MarketConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}