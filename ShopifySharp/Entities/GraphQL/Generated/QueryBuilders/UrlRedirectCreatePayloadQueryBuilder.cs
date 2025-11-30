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

public class UrlRedirectCreatePayloadQueryBuilder() : GraphQueryBuilder<UrlRedirectCreatePayload>("query urlRedirectCreatePayload")
{
    public UrlRedirectCreatePayloadQueryBuilder AddFieldUrlRedirect()
    {
        AddField("urlRedirect");
        return this;
    }

    public UrlRedirectCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}