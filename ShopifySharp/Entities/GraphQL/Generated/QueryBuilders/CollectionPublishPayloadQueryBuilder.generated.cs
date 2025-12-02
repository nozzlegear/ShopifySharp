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

public class CollectionPublishPayloadQueryBuilder() : GraphQueryBuilder<CollectionPublishPayload>("collectionPublishPayload")
{
    public CollectionPublishPayloadQueryBuilder AddFieldCollection(Func<CollectionQueryBuilder, CollectionQueryBuilder> build)
    {
        AddField<Collection, CollectionQueryBuilder>("collection", build);
        return this;
    }

    public CollectionPublishPayloadQueryBuilder AddFieldCollectionPublications(Func<CollectionPublicationQueryBuilder, CollectionPublicationQueryBuilder> build)
    {
        AddField<CollectionPublication, CollectionPublicationQueryBuilder>("collectionPublications", build);
        return this;
    }

    public CollectionPublishPayloadQueryBuilder AddFieldShop(Func<ShopQueryBuilder, ShopQueryBuilder> build)
    {
        AddField<Shop, ShopQueryBuilder>("shop", build);
        return this;
    }

    public CollectionPublishPayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}