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

public class MobilePlatformApplicationCreatePayloadQueryBuilder() : GraphQueryBuilder<MobilePlatformApplicationCreatePayload>("query mobilePlatformApplicationCreatePayload")
{
    public MobilePlatformApplicationCreatePayloadQueryBuilder AddFieldMobilePlatformApplication()
    {
        AddField("mobilePlatformApplication");
        return this;
    }

    public MobilePlatformApplicationCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}