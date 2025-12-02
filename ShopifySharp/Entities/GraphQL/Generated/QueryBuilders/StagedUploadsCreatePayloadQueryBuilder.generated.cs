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

public class StagedUploadsCreatePayloadQueryBuilder() : GraphQueryBuilder<StagedUploadsCreatePayload>("stagedUploadsCreatePayload")
{
    public StagedUploadsCreatePayloadQueryBuilder AddFieldStagedTargets(Func<StagedMediaUploadTargetQueryBuilder, StagedMediaUploadTargetQueryBuilder> build)
    {
        AddField<StagedMediaUploadTarget, StagedMediaUploadTargetQueryBuilder>("stagedTargets", build);
        return this;
    }

    public StagedUploadsCreatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}