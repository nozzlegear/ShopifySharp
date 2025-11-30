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

public class StagedMediaUploadTargetQueryBuilder() : GraphQueryBuilder<StagedMediaUploadTarget>("query stagedMediaUploadTarget")
{
    public StagedMediaUploadTargetQueryBuilder AddFieldParameters()
    {
        AddField("parameters");
        return this;
    }

    public StagedMediaUploadTargetQueryBuilder AddFieldResourceUrl()
    {
        AddField("resourceUrl");
        return this;
    }

    public StagedMediaUploadTargetQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}