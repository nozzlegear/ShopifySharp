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

public class ThemeFilesDeletePayloadQueryBuilder() : GraphQueryBuilder<ThemeFilesDeletePayload>("themeFilesDeletePayload")
{
    public ThemeFilesDeletePayloadQueryBuilder AddFieldDeletedThemeFiles(Func<OnlineStoreThemeFileOperationResultQueryBuilder, OnlineStoreThemeFileOperationResultQueryBuilder> build)
    {
        AddField<OnlineStoreThemeFileOperationResult, OnlineStoreThemeFileOperationResultQueryBuilder>("deletedThemeFiles", build);
        return this;
    }

    public ThemeFilesDeletePayloadQueryBuilder AddFieldUserErrors(Func<OnlineStoreThemeFilesUserErrorsQueryBuilder, OnlineStoreThemeFilesUserErrorsQueryBuilder> build)
    {
        AddField<OnlineStoreThemeFilesUserErrors, OnlineStoreThemeFilesUserErrorsQueryBuilder>("userErrors", build);
        return this;
    }
}