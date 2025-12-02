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

public class WebPixelDeletePayloadQueryBuilder() : GraphQueryBuilder<WebPixelDeletePayload>("webPixelDeletePayload")
{
    public WebPixelDeletePayloadQueryBuilder AddFieldDeletedWebPixelId()
    {
        AddField("deletedWebPixelId");
        return this;
    }

    public WebPixelDeletePayloadQueryBuilder AddFieldUserErrors(Func<ErrorsWebPixelUserErrorQueryBuilder, ErrorsWebPixelUserErrorQueryBuilder> build)
    {
        AddField<ErrorsWebPixelUserError, ErrorsWebPixelUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}