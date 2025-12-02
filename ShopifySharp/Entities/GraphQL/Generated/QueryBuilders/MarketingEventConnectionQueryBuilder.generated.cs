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

public class MarketingEventConnectionQueryBuilder() : GraphQueryBuilder<MarketingEventConnection>("marketingEventConnection")
{
    public MarketingEventConnectionQueryBuilder AddFieldEdges(Func<MarketingEventEdgeQueryBuilder, MarketingEventEdgeQueryBuilder> build)
    {
        AddField<MarketingEventEdge, MarketingEventEdgeQueryBuilder>("edges", build);
        return this;
    }

    public MarketingEventConnectionQueryBuilder AddFieldNodes(Func<MarketingEventQueryBuilder, MarketingEventQueryBuilder> build)
    {
        AddField<MarketingEvent, MarketingEventQueryBuilder>("nodes", build);
        return this;
    }

    public MarketingEventConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}