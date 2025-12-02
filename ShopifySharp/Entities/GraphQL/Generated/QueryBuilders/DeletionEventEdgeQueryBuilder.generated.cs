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

public class DeletionEventEdgeQueryBuilder() : GraphQueryBuilder<DeletionEventEdge>("deletionEventEdge")
{
    public DeletionEventEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public DeletionEventEdgeQueryBuilder AddFieldNode(Func<DeletionEventQueryBuilder, DeletionEventQueryBuilder> build)
    {
        AddField<DeletionEvent, DeletionEventQueryBuilder>("node", build);
        return this;
    }
}