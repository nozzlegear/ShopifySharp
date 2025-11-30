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

public class EventBridgeServerPixelUpdatePayloadQueryBuilder() : GraphQueryBuilder<EventBridgeServerPixelUpdatePayload>("query eventBridgeServerPixelUpdatePayload")
{
    public EventBridgeServerPixelUpdatePayloadQueryBuilder AddFieldServerPixel()
    {
        AddField("serverPixel");
        return this;
    }

    public EventBridgeServerPixelUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}