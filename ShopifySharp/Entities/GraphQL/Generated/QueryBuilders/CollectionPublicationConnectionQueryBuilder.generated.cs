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

public class CollectionPublicationConnectionQueryBuilder() : GraphQueryBuilder<CollectionPublicationConnection>("collectionPublicationConnection")
{
    public CollectionPublicationConnectionQueryBuilder AddFieldEdges(Func<CollectionPublicationEdgeQueryBuilder, CollectionPublicationEdgeQueryBuilder> build)
    {
        AddField<CollectionPublicationEdge, CollectionPublicationEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CollectionPublicationConnectionQueryBuilder AddFieldNodes(Func<CollectionPublicationQueryBuilder, CollectionPublicationQueryBuilder> build)
    {
        AddField<CollectionPublication, CollectionPublicationQueryBuilder>("nodes", build);
        return this;
    }

    public CollectionPublicationConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}