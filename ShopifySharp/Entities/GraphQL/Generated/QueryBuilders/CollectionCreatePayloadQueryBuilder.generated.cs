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

public class CollectionCreatePayloadQueryBuilder() : GraphQueryBuilder<CollectionCreatePayload>("collectionCreatePayload")
{
    public CollectionCreatePayloadQueryBuilder AddFieldCollection(Func<CollectionQueryBuilder, CollectionQueryBuilder> build)
    {
        AddField<Collection, CollectionQueryBuilder>("collection", build);
        return this;
    }

    public CollectionCreatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}