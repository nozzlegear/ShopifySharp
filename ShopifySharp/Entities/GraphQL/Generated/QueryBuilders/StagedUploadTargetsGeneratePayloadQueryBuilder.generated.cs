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

public class StagedUploadTargetsGeneratePayloadQueryBuilder() : GraphQueryBuilder<StagedUploadTargetsGeneratePayload>("stagedUploadTargetsGeneratePayload")
{
    public StagedUploadTargetsGeneratePayloadQueryBuilder AddFieldUrls(Func<StagedUploadTargetQueryBuilder, StagedUploadTargetQueryBuilder> build)
    {
        AddField<StagedUploadTarget, StagedUploadTargetQueryBuilder>("urls", build);
        return this;
    }

    public StagedUploadTargetsGeneratePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}