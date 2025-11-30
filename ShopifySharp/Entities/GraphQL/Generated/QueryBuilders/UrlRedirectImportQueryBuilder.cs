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

public class UrlRedirectImportQueryBuilder() : GraphQueryBuilder<UrlRedirectImport>("query urlRedirectImport")
{
    public UrlRedirectImportQueryBuilder AddFieldCount()
    {
        AddField("count");
        return this;
    }

    public UrlRedirectImportQueryBuilder AddFieldCreatedCount()
    {
        AddField("createdCount");
        return this;
    }

    public UrlRedirectImportQueryBuilder AddFieldFailedCount()
    {
        AddField("failedCount");
        return this;
    }

    public UrlRedirectImportQueryBuilder AddFieldFinished()
    {
        AddField("finished");
        return this;
    }

    public UrlRedirectImportQueryBuilder AddFieldFinishedAt()
    {
        AddField("finishedAt");
        return this;
    }

    public UrlRedirectImportQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public UrlRedirectImportQueryBuilder AddFieldPreviewRedirects()
    {
        AddField("previewRedirects");
        return this;
    }

    public UrlRedirectImportQueryBuilder AddFieldUpdatedCount()
    {
        AddField("updatedCount");
        return this;
    }
}