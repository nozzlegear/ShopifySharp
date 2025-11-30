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

public class StagedUploadTargetQueryBuilder() : GraphQueryBuilder<StagedUploadTarget>("query stagedUploadTarget")
{
    public StagedUploadTargetQueryBuilder AddFieldParameters()
    {
        AddField("parameters");
        return this;
    }

    public StagedUploadTargetQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}