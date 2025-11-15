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

public class ServerPixelCreatePayloadQueryBuilder() : GraphQueryBuilder<ServerPixelCreatePayload>("query serverPixelCreatePayload")
{
    public ServerPixelCreatePayloadQueryBuilder AddFieldServerPixel()
    {
        AddField("serverPixel");
        return this;
    }

    public ServerPixelCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}