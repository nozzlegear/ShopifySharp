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

public class StorefrontAccessTokenCreatePayloadQueryBuilder() : GraphQueryBuilder<StorefrontAccessTokenCreatePayload>("storefrontAccessTokenCreatePayload")
{
    public StorefrontAccessTokenCreatePayloadQueryBuilder AddFieldShop(Func<ShopQueryBuilder, ShopQueryBuilder> build)
    {
        AddField<Shop, ShopQueryBuilder>("shop", build);
        return this;
    }

    public StorefrontAccessTokenCreatePayloadQueryBuilder AddFieldStorefrontAccessToken(Func<StorefrontAccessTokenQueryBuilder, StorefrontAccessTokenQueryBuilder> build)
    {
        AddField<StorefrontAccessToken, StorefrontAccessTokenQueryBuilder>("storefrontAccessToken", build);
        return this;
    }

    public StorefrontAccessTokenCreatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}