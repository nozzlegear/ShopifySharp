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

public class DelegateAccessTokenQueryBuilder() : GraphQueryBuilder<DelegateAccessToken>("delegateAccessToken")
{
    public DelegateAccessTokenQueryBuilder AddFieldAccessScopes()
    {
        AddField("accessScopes");
        return this;
    }

    public DelegateAccessTokenQueryBuilder AddFieldAccessToken()
    {
        AddField("accessToken");
        return this;
    }

    public DelegateAccessTokenQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }
}