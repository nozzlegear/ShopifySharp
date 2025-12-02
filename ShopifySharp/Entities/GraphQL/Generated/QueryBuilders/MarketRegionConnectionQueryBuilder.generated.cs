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

public class MarketRegionConnectionQueryBuilder() : GraphQueryBuilder<MarketRegionConnection>("marketRegionConnection")
{
    public MarketRegionConnectionQueryBuilder AddFieldEdges(Func<MarketRegionEdgeQueryBuilder, MarketRegionEdgeQueryBuilder> build)
    {
        AddField<MarketRegionEdge, MarketRegionEdgeQueryBuilder>("edges", build);
        return this;
    }

    public MarketRegionConnectionQueryBuilder AddFieldNodes(Func<MarketRegionQueryBuilder, MarketRegionQueryBuilder> build)
    {
        AddField<IMarketRegion, MarketRegionQueryBuilder>("nodes", build);
        return this;
    }

    public MarketRegionConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}