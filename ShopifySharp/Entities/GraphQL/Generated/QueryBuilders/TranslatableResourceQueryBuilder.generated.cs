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

public class TranslatableResourceQueryBuilder() : GraphQueryBuilder<TranslatableResource>("translatableResource")
{
    public TranslatableResourceQueryBuilder AddFieldNestedTranslatableResources(Func<TranslatableResourceConnectionQueryBuilder, TranslatableResourceConnectionQueryBuilder> build)
    {
        AddField<TranslatableResourceConnection, TranslatableResourceConnectionQueryBuilder>("nestedTranslatableResources", build);
        return this;
    }

    public TranslatableResourceQueryBuilder AddFieldResourceId()
    {
        AddField("resourceId");
        return this;
    }

    public TranslatableResourceQueryBuilder AddFieldTranslatableContent(Func<TranslatableContentQueryBuilder, TranslatableContentQueryBuilder> build)
    {
        AddField<TranslatableContent, TranslatableContentQueryBuilder>("translatableContent", build);
        return this;
    }

    public TranslatableResourceQueryBuilder AddFieldTranslations(Func<TranslationQueryBuilder, TranslationQueryBuilder> build)
    {
        AddField<Translation, TranslationQueryBuilder>("translations", build);
        return this;
    }
}