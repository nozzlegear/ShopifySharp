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

public class StagedUploadTargetGeneratePayloadQueryBuilder() : GraphQueryBuilder<StagedUploadTargetGeneratePayload>("stagedUploadTargetGeneratePayload")
{
    public StagedUploadTargetGeneratePayloadQueryBuilder AddFieldParameters(Func<MutationsStagedUploadTargetGenerateUploadParameterQueryBuilder, MutationsStagedUploadTargetGenerateUploadParameterQueryBuilder> build)
    {
        AddField<MutationsStagedUploadTargetGenerateUploadParameter, MutationsStagedUploadTargetGenerateUploadParameterQueryBuilder>("parameters", build);
        return this;
    }

    public StagedUploadTargetGeneratePayloadQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }

    public StagedUploadTargetGeneratePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}