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

public class MobilePlatformApplicationDeletePayloadQueryBuilder() : GraphQueryBuilder<MobilePlatformApplicationDeletePayload>("query mobilePlatformApplicationDeletePayload")
{
    public MobilePlatformApplicationDeletePayloadQueryBuilder AddFieldDeletedMobilePlatformApplicationId()
    {
        AddField("deletedMobilePlatformApplicationId");
        return this;
    }

    public MobilePlatformApplicationDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}