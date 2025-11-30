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

public class ThemeFilesUpsertQueryBuilder() : GraphQueryBuilder<ThemeFilesUpsertPayload>("themeFilesUpsert"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public ThemeFilesUpsertQueryBuilder AddArgumentFiles(ICollection<OnlineStoreThemeFilesUpsertFileInput>? files)
    {
        AddArgument("files", files);
        return this;
    }

    public ThemeFilesUpsertQueryBuilder AddArgumentThemeId(string? themeId)
    {
        AddArgument("themeId", themeId);
        return this;
    }
}