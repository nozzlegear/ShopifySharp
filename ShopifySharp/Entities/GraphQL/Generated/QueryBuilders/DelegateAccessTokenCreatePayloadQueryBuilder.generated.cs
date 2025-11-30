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

public class DelegateAccessTokenCreatePayloadQueryBuilder() : GraphQueryBuilder<DelegateAccessTokenCreatePayload>("delegateAccessTokenCreatePayload")
{
    public DelegateAccessTokenCreatePayloadQueryBuilder AddFieldDelegateAccessToken(Func<DelegateAccessTokenQueryBuilder, DelegateAccessTokenQueryBuilder> build)
    {
        AddField<DelegateAccessToken, DelegateAccessTokenQueryBuilder>("delegateAccessToken", build);
        return this;
    }

    public DelegateAccessTokenCreatePayloadQueryBuilder AddFieldShop(Func<ShopQueryBuilder, ShopQueryBuilder> build)
    {
        AddField<Shop, ShopQueryBuilder>("shop", build);
        return this;
    }

    public DelegateAccessTokenCreatePayloadQueryBuilder AddFieldUserErrors(Func<DelegateAccessTokenCreateUserErrorQueryBuilder, DelegateAccessTokenCreateUserErrorQueryBuilder> build)
    {
        AddField<DelegateAccessTokenCreateUserError, DelegateAccessTokenCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}