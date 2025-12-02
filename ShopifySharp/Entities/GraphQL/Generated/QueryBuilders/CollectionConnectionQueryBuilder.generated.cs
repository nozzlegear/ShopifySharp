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

public class CollectionConnectionQueryBuilder() : GraphQueryBuilder<CollectionConnection>("collectionConnection")
{
    public CollectionConnectionQueryBuilder AddFieldEdges(Func<CollectionEdgeQueryBuilder, CollectionEdgeQueryBuilder> build)
    {
        AddField<CollectionEdge, CollectionEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CollectionConnectionQueryBuilder AddFieldNodes(Func<CollectionQueryBuilder, CollectionQueryBuilder> build)
    {
        AddField<Collection, CollectionQueryBuilder>("nodes", build);
        return this;
    }

    public CollectionConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}