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

public class EventConnectionQueryBuilder() : GraphQueryBuilder<EventConnection>("eventConnection")
{
    public EventConnectionQueryBuilder AddFieldEdges(Func<EventEdgeQueryBuilder, EventEdgeQueryBuilder> build)
    {
        AddField<EventEdge, EventEdgeQueryBuilder>("edges", build);
        return this;
    }

    public EventConnectionQueryBuilder AddFieldNodes(Func<EventQueryBuilder, EventQueryBuilder> build)
    {
        AddField<IEvent, EventQueryBuilder>("nodes", build);
        return this;
    }

    public EventConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}