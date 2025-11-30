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

public class MobilePlatformApplicationUpdatePayloadQueryBuilder() : GraphQueryBuilder<MobilePlatformApplicationUpdatePayload>("query mobilePlatformApplicationUpdatePayload")
{
    public MobilePlatformApplicationUpdatePayloadQueryBuilder AddFieldMobilePlatformApplication()
    {
        AddField("mobilePlatformApplication");
        return this;
    }

    public MobilePlatformApplicationUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}