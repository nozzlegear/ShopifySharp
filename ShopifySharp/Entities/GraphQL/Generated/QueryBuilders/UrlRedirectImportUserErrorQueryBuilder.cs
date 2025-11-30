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

public class UrlRedirectImportUserErrorQueryBuilder() : GraphQueryBuilder<UrlRedirectImportUserError>("query urlRedirectImportUserError")
{
    public UrlRedirectImportUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public UrlRedirectImportUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public UrlRedirectImportUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}