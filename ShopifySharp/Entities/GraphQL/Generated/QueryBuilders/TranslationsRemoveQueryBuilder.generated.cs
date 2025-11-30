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

public class TranslationsRemoveQueryBuilder() : GraphQueryBuilder<TranslationsRemovePayload>("translationsRemove"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public TranslationsRemoveQueryBuilder AddArgumentLocales(ICollection<string>? locales)
    {
        AddArgument("locales", locales);
        return this;
    }

    public TranslationsRemoveQueryBuilder AddArgumentMarketIds(ICollection<string>? marketIds)
    {
        AddArgument("marketIds", marketIds);
        return this;
    }

    public TranslationsRemoveQueryBuilder AddArgumentResourceId(string? resourceId)
    {
        AddArgument("resourceId", resourceId);
        return this;
    }

    public TranslationsRemoveQueryBuilder AddArgumentTranslationKeys(ICollection<string>? translationKeys)
    {
        AddArgument("translationKeys", translationKeys);
        return this;
    }
}