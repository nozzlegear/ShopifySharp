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

public class UrlRedirectImportCreateQueryBuilder() : GraphQueryBuilder<UrlRedirectImportCreatePayload>("query urlRedirectImportCreate")
{
    public UrlRedirectImportCreateQueryBuilder AddArgumentUrl(string? url)
    {
        AddArgument("url", url);
        return this;
    }
}