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

public class StorefrontAccessTokenDeletePayloadQueryBuilder() : GraphQueryBuilder<StorefrontAccessTokenDeletePayload>("query storefrontAccessTokenDeletePayload")
{
    public StorefrontAccessTokenDeletePayloadQueryBuilder AddFieldDeletedStorefrontAccessTokenId()
    {
        AddField("deletedStorefrontAccessTokenId");
        return this;
    }

    public StorefrontAccessTokenDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}