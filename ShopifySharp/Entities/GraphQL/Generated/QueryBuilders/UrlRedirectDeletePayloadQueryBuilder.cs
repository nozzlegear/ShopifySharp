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

public class UrlRedirectDeletePayloadQueryBuilder() : GraphQueryBuilder<UrlRedirectDeletePayload>("query urlRedirectDeletePayload")
{
    public UrlRedirectDeletePayloadQueryBuilder AddFieldDeletedUrlRedirectId()
    {
        AddField("deletedUrlRedirectId");
        return this;
    }

    public UrlRedirectDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}