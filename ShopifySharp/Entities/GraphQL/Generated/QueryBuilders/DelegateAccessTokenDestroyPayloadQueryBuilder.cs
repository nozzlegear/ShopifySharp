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

public class DelegateAccessTokenDestroyPayloadQueryBuilder() : GraphQueryBuilder<DelegateAccessTokenDestroyPayload>("query delegateAccessTokenDestroyPayload")
{
    public DelegateAccessTokenDestroyPayloadQueryBuilder AddFieldShop()
    {
        AddField("shop");
        return this;
    }

    public DelegateAccessTokenDestroyPayloadQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public DelegateAccessTokenDestroyPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}