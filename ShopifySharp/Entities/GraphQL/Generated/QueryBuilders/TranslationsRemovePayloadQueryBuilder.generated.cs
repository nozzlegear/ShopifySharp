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

public class TranslationsRemovePayloadQueryBuilder() : GraphQueryBuilder<TranslationsRemovePayload>("translationsRemovePayload")
{
    public TranslationsRemovePayloadQueryBuilder AddFieldTranslations(Func<TranslationQueryBuilder, TranslationQueryBuilder> build)
    {
        AddField<Translation, TranslationQueryBuilder>("translations", build);
        return this;
    }

    public TranslationsRemovePayloadQueryBuilder AddFieldUserErrors(Func<TranslationUserErrorQueryBuilder, TranslationUserErrorQueryBuilder> build)
    {
        AddField<TranslationUserError, TranslationUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}