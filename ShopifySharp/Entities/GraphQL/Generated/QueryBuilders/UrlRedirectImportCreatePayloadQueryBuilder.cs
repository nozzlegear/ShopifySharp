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

public class UrlRedirectImportCreatePayloadQueryBuilder() : GraphQueryBuilder<UrlRedirectImportCreatePayload>("query urlRedirectImportCreatePayload")
{
    public UrlRedirectImportCreatePayloadQueryBuilder AddFieldUrlRedirectImport()
    {
        AddField("urlRedirectImport");
        return this;
    }

    public UrlRedirectImportCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}