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

public class CollectionUnpublishPayloadQueryBuilder() : GraphQueryBuilder<CollectionUnpublishPayload>("collectionUnpublishPayload")
{
    public CollectionUnpublishPayloadQueryBuilder AddFieldCollection(Func<CollectionQueryBuilder, CollectionQueryBuilder> build)
    {
        AddField<Collection, CollectionQueryBuilder>("collection", build);
        return this;
    }

    public CollectionUnpublishPayloadQueryBuilder AddFieldShop(Func<ShopQueryBuilder, ShopQueryBuilder> build)
    {
        AddField<Shop, ShopQueryBuilder>("shop", build);
        return this;
    }

    public CollectionUnpublishPayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}