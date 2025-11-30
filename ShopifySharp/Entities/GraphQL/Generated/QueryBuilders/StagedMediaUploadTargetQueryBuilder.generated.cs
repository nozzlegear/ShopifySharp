#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class StagedMediaUploadTargetQueryBuilder() : GraphQueryBuilder<StagedMediaUploadTarget>("stagedMediaUploadTarget")
{
    public StagedMediaUploadTargetQueryBuilder AddFieldParameters(Func<StagedUploadParameterQueryBuilder, StagedUploadParameterQueryBuilder> build)
    {
        AddField<StagedUploadParameter, StagedUploadParameterQueryBuilder>("parameters", build);
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