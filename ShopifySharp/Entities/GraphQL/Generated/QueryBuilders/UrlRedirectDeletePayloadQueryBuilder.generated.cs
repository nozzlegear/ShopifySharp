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

public class UrlRedirectDeletePayloadQueryBuilder() : GraphQueryBuilder<UrlRedirectDeletePayload>("urlRedirectDeletePayload")
{
    public UrlRedirectDeletePayloadQueryBuilder AddFieldDeletedUrlRedirectId()
    {
        AddField("deletedUrlRedirectId");
        return this;
    }

    public UrlRedirectDeletePayloadQueryBuilder AddFieldUserErrors(Func<UrlRedirectUserErrorQueryBuilder, UrlRedirectUserErrorQueryBuilder> build)
    {
        AddField<UrlRedirectUserError, UrlRedirectUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}