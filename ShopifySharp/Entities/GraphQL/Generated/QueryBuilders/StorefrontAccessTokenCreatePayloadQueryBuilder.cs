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

public class StorefrontAccessTokenCreatePayloadQueryBuilder() : GraphQueryBuilder<StorefrontAccessTokenCreatePayload>("query storefrontAccessTokenCreatePayload")
{
    public StorefrontAccessTokenCreatePayloadQueryBuilder AddFieldShop()
    {
        AddField("shop");
        return this;
    }

    public StorefrontAccessTokenCreatePayloadQueryBuilder AddFieldStorefrontAccessToken()
    {
        AddField("storefrontAccessToken");
        return this;
    }

    public StorefrontAccessTokenCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}