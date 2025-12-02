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

public class CollectionDeletePayloadQueryBuilder() : GraphQueryBuilder<CollectionDeletePayload>("collectionDeletePayload")
{
    public CollectionDeletePayloadQueryBuilder AddFieldDeletedCollectionId()
    {
        AddField("deletedCollectionId");
        return this;
    }

    public CollectionDeletePayloadQueryBuilder AddFieldShop(Func<ShopQueryBuilder, ShopQueryBuilder> build)
    {
        AddField<Shop, ShopQueryBuilder>("shop", build);
        return this;
    }

    public CollectionDeletePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}