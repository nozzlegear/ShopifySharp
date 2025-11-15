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

public class UrlRedirectUpdateQueryBuilder() : GraphQueryBuilder<UrlRedirectUpdatePayload>("query urlRedirectUpdate")
{
    public UrlRedirectUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public UrlRedirectUpdateQueryBuilder AddArgumentUrlRedirect(UrlRedirectInput? urlRedirect)
    {
        AddArgument("urlRedirect", urlRedirect);
        return this;
    }
}