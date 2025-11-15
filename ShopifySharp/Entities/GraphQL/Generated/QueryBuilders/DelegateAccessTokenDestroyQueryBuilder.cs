#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class DelegateAccessTokenDestroyQueryBuilder() : GraphQueryBuilder<DelegateAccessTokenDestroyPayload>("query delegateAccessTokenDestroy")
{
    public DelegateAccessTokenDestroyQueryBuilder AddArgumentAccessToken(string? accessToken)
    {
        AddArgument("accessToken", accessToken);
        return this;
    }
}