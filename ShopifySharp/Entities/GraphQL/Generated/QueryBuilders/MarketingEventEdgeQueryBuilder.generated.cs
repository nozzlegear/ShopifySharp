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

public class MarketingEventEdgeQueryBuilder() : GraphQueryBuilder<MarketingEventEdge>("marketingEventEdge")
{
    public MarketingEventEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public MarketingEventEdgeQueryBuilder AddFieldNode(Func<MarketingEventQueryBuilder, MarketingEventQueryBuilder> build)
    {
        AddField<MarketingEvent, MarketingEventQueryBuilder>("node", build);
        return this;
    }
}