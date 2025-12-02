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

public class MarketWebPresenceConnectionQueryBuilder() : GraphQueryBuilder<MarketWebPresenceConnection>("marketWebPresenceConnection")
{
    public MarketWebPresenceConnectionQueryBuilder AddFieldEdges(Func<MarketWebPresenceEdgeQueryBuilder, MarketWebPresenceEdgeQueryBuilder> build)
    {
        AddField<MarketWebPresenceEdge, MarketWebPresenceEdgeQueryBuilder>("edges", build);
        return this;
    }

    public MarketWebPresenceConnectionQueryBuilder AddFieldNodes(Func<MarketWebPresenceQueryBuilder, MarketWebPresenceQueryBuilder> build)
    {
        AddField<MarketWebPresence, MarketWebPresenceQueryBuilder>("nodes", build);
        return this;
    }

    public MarketWebPresenceConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}