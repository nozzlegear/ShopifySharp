#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class EventBridgeServerPixelUpdatePayloadQueryBuilder() : GraphQueryBuilder<EventBridgeServerPixelUpdatePayload>("eventBridgeServerPixelUpdatePayload")
{
    public EventBridgeServerPixelUpdatePayloadQueryBuilder AddFieldServerPixel(Func<ServerPixelQueryBuilder, ServerPixelQueryBuilder> build)
    {
        AddField<ServerPixel, ServerPixelQueryBuilder>("serverPixel", build);
        return this;
    }

    public EventBridgeServerPixelUpdatePayloadQueryBuilder AddFieldUserErrors(Func<ErrorsServerPixelUserErrorQueryBuilder, ErrorsServerPixelUserErrorQueryBuilder> build)
    {
        AddField<ErrorsServerPixelUserError, ErrorsServerPixelUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}