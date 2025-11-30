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

public class DelegateAccessTokenDestroyPayloadQueryBuilder() : GraphQueryBuilder<DelegateAccessTokenDestroyPayload>("delegateAccessTokenDestroyPayload")
{
    public DelegateAccessTokenDestroyPayloadQueryBuilder AddFieldShop(Func<ShopQueryBuilder, ShopQueryBuilder> build)
    {
        AddField<Shop, ShopQueryBuilder>("shop", build);
        return this;
    }

    public DelegateAccessTokenDestroyPayloadQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public DelegateAccessTokenDestroyPayloadQueryBuilder AddFieldUserErrors(Func<DelegateAccessTokenDestroyUserErrorQueryBuilder, DelegateAccessTokenDestroyUserErrorQueryBuilder> build)
    {
        AddField<DelegateAccessTokenDestroyUserError, DelegateAccessTokenDestroyUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}