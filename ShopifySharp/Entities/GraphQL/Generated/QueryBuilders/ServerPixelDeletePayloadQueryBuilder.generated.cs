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

public class ServerPixelDeletePayloadQueryBuilder() : GraphQueryBuilder<ServerPixelDeletePayload>("serverPixelDeletePayload")
{
    public ServerPixelDeletePayloadQueryBuilder AddFieldDeletedServerPixelId()
    {
        AddField("deletedServerPixelId");
        return this;
    }

    public ServerPixelDeletePayloadQueryBuilder AddFieldUserErrors(Func<ErrorsServerPixelUserErrorQueryBuilder, ErrorsServerPixelUserErrorQueryBuilder> build)
    {
        AddField<ErrorsServerPixelUserError, ErrorsServerPixelUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}