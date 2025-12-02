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

public class ThemeFilesUpsertPayloadQueryBuilder() : GraphQueryBuilder<ThemeFilesUpsertPayload>("themeFilesUpsertPayload")
{
    public ThemeFilesUpsertPayloadQueryBuilder AddFieldJob(Func<JobQueryBuilder, JobQueryBuilder> build)
    {
        AddField<Job, JobQueryBuilder>("job", build);
        return this;
    }

    public ThemeFilesUpsertPayloadQueryBuilder AddFieldUpsertedThemeFiles(Func<OnlineStoreThemeFileOperationResultQueryBuilder, OnlineStoreThemeFileOperationResultQueryBuilder> build)
    {
        AddField<OnlineStoreThemeFileOperationResult, OnlineStoreThemeFileOperationResultQueryBuilder>("upsertedThemeFiles", build);
        return this;
    }

    public ThemeFilesUpsertPayloadQueryBuilder AddFieldUserErrors(Func<OnlineStoreThemeFilesUserErrorsQueryBuilder, OnlineStoreThemeFilesUserErrorsQueryBuilder> build)
    {
        AddField<OnlineStoreThemeFilesUserErrors, OnlineStoreThemeFilesUserErrorsQueryBuilder>("userErrors", build);
        return this;
    }
}