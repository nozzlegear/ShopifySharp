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

public class DelegateAccessTokenCreatePayloadQueryBuilder() : GraphQueryBuilder<DelegateAccessTokenCreatePayload>("query delegateAccessTokenCreatePayload")
{
    public DelegateAccessTokenCreatePayloadQueryBuilder AddFieldDelegateAccessToken()
    {
        AddField("delegateAccessToken");
        return this;
    }

    public DelegateAccessTokenCreatePayloadQueryBuilder AddFieldShop()
    {
        AddField("shop");
        return this;
    }

    public DelegateAccessTokenCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}