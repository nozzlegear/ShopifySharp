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

public class ThemeFilesCopyPayloadQueryBuilder() : GraphQueryBuilder<ThemeFilesCopyPayload>("themeFilesCopyPayload")
{
    public ThemeFilesCopyPayloadQueryBuilder AddFieldCopiedThemeFiles(Func<OnlineStoreThemeFileOperationResultQueryBuilder, OnlineStoreThemeFileOperationResultQueryBuilder> build)
    {
        AddField<OnlineStoreThemeFileOperationResult, OnlineStoreThemeFileOperationResultQueryBuilder>("copiedThemeFiles", build);
        return this;
    }

    public ThemeFilesCopyPayloadQueryBuilder AddFieldUserErrors(Func<OnlineStoreThemeFilesUserErrorsQueryBuilder, OnlineStoreThemeFilesUserErrorsQueryBuilder> build)
    {
        AddField<OnlineStoreThemeFilesUserErrors, OnlineStoreThemeFilesUserErrorsQueryBuilder>("userErrors", build);
        return this;
    }
}