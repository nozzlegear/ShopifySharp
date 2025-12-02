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

public class MarketLocalizableResourceConnectionQueryBuilder() : GraphQueryBuilder<MarketLocalizableResourceConnection>("marketLocalizableResourceConnection")
{
    public MarketLocalizableResourceConnectionQueryBuilder AddFieldEdges(Func<MarketLocalizableResourceEdgeQueryBuilder, MarketLocalizableResourceEdgeQueryBuilder> build)
    {
        AddField<MarketLocalizableResourceEdge, MarketLocalizableResourceEdgeQueryBuilder>("edges", build);
        return this;
    }

    public MarketLocalizableResourceConnectionQueryBuilder AddFieldNodes(Func<MarketLocalizableResourceQueryBuilder, MarketLocalizableResourceQueryBuilder> build)
    {
        AddField<MarketLocalizableResource, MarketLocalizableResourceQueryBuilder>("nodes", build);
        return this;
    }

    public MarketLocalizableResourceConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}