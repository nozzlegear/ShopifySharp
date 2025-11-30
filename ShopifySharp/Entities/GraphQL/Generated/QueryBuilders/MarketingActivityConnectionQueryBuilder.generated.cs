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

public class MarketingActivityConnectionQueryBuilder() : GraphQueryBuilder<MarketingActivityConnection>("marketingActivityConnection")
{
    public MarketingActivityConnectionQueryBuilder AddFieldEdges(Func<MarketingActivityEdgeQueryBuilder, MarketingActivityEdgeQueryBuilder> build)
    {
        AddField<MarketingActivityEdge, MarketingActivityEdgeQueryBuilder>("edges", build);
        return this;
    }

    public MarketingActivityConnectionQueryBuilder AddFieldNodes(Func<MarketingActivityQueryBuilder, MarketingActivityQueryBuilder> build)
    {
        AddField<MarketingActivity, MarketingActivityQueryBuilder>("nodes", build);
        return this;
    }

    public MarketingActivityConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}