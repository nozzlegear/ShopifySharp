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

public class CollectionPublicationEdgeQueryBuilder() : GraphQueryBuilder<CollectionPublicationEdge>("collectionPublicationEdge")
{
    public CollectionPublicationEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CollectionPublicationEdgeQueryBuilder AddFieldNode(Func<CollectionPublicationQueryBuilder, CollectionPublicationQueryBuilder> build)
    {
        AddField<CollectionPublication, CollectionPublicationQueryBuilder>("node", build);
        return this;
    }
}