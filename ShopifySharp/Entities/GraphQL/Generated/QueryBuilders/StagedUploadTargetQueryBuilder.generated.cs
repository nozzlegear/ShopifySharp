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

public class StagedUploadTargetQueryBuilder() : GraphQueryBuilder<StagedUploadTarget>("stagedUploadTarget")
{
    public StagedUploadTargetQueryBuilder AddFieldParameters(Func<ImageUploadParameterQueryBuilder, ImageUploadParameterQueryBuilder> build)
    {
        AddField<ImageUploadParameter, ImageUploadParameterQueryBuilder>("parameters", build);
        return this;
    }

    public StagedUploadTargetQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}