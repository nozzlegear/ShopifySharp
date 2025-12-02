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

public class StorefrontAccessTokenQueryBuilder() : GraphQueryBuilder<StorefrontAccessToken>("storefrontAccessToken")
{
    public StorefrontAccessTokenQueryBuilder AddFieldAccessScopes(Func<AccessScopeQueryBuilder, AccessScopeQueryBuilder> build)
    {
        AddField<AccessScope, AccessScopeQueryBuilder>("accessScopes", build);
        return this;
    }

    public StorefrontAccessTokenQueryBuilder AddFieldAccessToken()
    {
        AddField("accessToken");
        return this;
    }

    public StorefrontAccessTokenQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public StorefrontAccessTokenQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public StorefrontAccessTokenQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public StorefrontAccessTokenQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}