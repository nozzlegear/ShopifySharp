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

public class UrlRedirectUpdatePayloadQueryBuilder() : GraphQueryBuilder<UrlRedirectUpdatePayload>("query urlRedirectUpdatePayload")
{
    public UrlRedirectUpdatePayloadQueryBuilder AddFieldUrlRedirect()
    {
        AddField("urlRedirect");
        return this;
    }

    public UrlRedirectUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}