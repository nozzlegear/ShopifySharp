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

public class MarketCatalogEdgeQueryBuilder() : GraphQueryBuilder<MarketCatalogEdge>("marketCatalogEdge")
{
    public MarketCatalogEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public MarketCatalogEdgeQueryBuilder AddFieldNode(Func<MarketCatalogQueryBuilder, MarketCatalogQueryBuilder> build)
    {
        AddField<MarketCatalog, MarketCatalogQueryBuilder>("node", build);
        return this;
    }
}