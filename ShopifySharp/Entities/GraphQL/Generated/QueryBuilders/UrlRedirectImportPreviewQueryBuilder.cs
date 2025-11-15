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

public class UrlRedirectImportPreviewQueryBuilder() : GraphQueryBuilder<UrlRedirectImportPreview>("query urlRedirectImportPreview")
{
    public UrlRedirectImportPreviewQueryBuilder AddFieldPath()
    {
        AddField("path");
        return this;
    }

    public UrlRedirectImportPreviewQueryBuilder AddFieldTarget()
    {
        AddField("target");
        return this;
    }
}