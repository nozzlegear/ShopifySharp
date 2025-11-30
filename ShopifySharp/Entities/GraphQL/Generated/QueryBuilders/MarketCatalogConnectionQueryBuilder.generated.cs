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

public class MarketCatalogConnectionQueryBuilder() : GraphQueryBuilder<MarketCatalogConnection>("marketCatalogConnection")
{
    public MarketCatalogConnectionQueryBuilder AddFieldEdges(Func<MarketCatalogEdgeQueryBuilder, MarketCatalogEdgeQueryBuilder> build)
    {
        AddField<MarketCatalogEdge, MarketCatalogEdgeQueryBuilder>("edges", build);
        return this;
    }

    public MarketCatalogConnectionQueryBuilder AddFieldNodes(Func<MarketCatalogQueryBuilder, MarketCatalogQueryBuilder> build)
    {
        AddField<MarketCatalog, MarketCatalogQueryBuilder>("nodes", build);
        return this;
    }

    public MarketCatalogConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}