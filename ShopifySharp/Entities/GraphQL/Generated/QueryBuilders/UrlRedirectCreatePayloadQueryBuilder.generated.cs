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

public class UrlRedirectCreatePayloadQueryBuilder() : GraphQueryBuilder<UrlRedirectCreatePayload>("urlRedirectCreatePayload")
{
    public UrlRedirectCreatePayloadQueryBuilder AddFieldUrlRedirect(Func<UrlRedirectQueryBuilder, UrlRedirectQueryBuilder> build)
    {
        AddField<UrlRedirect, UrlRedirectQueryBuilder>("urlRedirect", build);
        return this;
    }

    public UrlRedirectCreatePayloadQueryBuilder AddFieldUserErrors(Func<UrlRedirectUserErrorQueryBuilder, UrlRedirectUserErrorQueryBuilder> build)
    {
        AddField<UrlRedirectUserError, UrlRedirectUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}