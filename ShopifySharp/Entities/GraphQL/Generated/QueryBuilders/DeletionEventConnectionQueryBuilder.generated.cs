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

public class DeletionEventConnectionQueryBuilder() : GraphQueryBuilder<DeletionEventConnection>("deletionEventConnection")
{
    public DeletionEventConnectionQueryBuilder AddFieldEdges(Func<DeletionEventEdgeQueryBuilder, DeletionEventEdgeQueryBuilder> build)
    {
        AddField<DeletionEventEdge, DeletionEventEdgeQueryBuilder>("edges", build);
        return this;
    }

    public DeletionEventConnectionQueryBuilder AddFieldNodes(Func<DeletionEventQueryBuilder, DeletionEventQueryBuilder> build)
    {
        AddField<DeletionEvent, DeletionEventQueryBuilder>("nodes", build);
        return this;
    }

    public DeletionEventConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}