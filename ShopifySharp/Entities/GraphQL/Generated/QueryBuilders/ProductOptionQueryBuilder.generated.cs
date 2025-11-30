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

public class ProductOptionQueryBuilder() : GraphQueryBuilder<ProductOption>("productOption")
{
    public ProductOptionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ProductOptionQueryBuilder AddFieldLinkedMetafield(Func<LinkedMetafieldQueryBuilder, LinkedMetafieldQueryBuilder> build)
    {
        AddField<LinkedMetafield, LinkedMetafieldQueryBuilder>("linkedMetafield", build);
        return this;
    }

    public ProductOptionQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public ProductOptionQueryBuilder AddFieldOptionValues(Func<ProductOptionValueQueryBuilder, ProductOptionValueQueryBuilder> build)
    {
        AddField<ProductOptionValue, ProductOptionValueQueryBuilder>("optionValues", build);
        return this;
    }

    public ProductOptionQueryBuilder AddFieldPosition()
    {
        AddField("position");
        return this;
    }

    public ProductOptionQueryBuilder AddFieldTranslations(Func<TranslationQueryBuilder, TranslationQueryBuilder> build)
    {
        AddField<Translation, TranslationQueryBuilder>("translations", build);
        return this;
    }

    public ProductOptionQueryBuilder AddFieldValues()
    {
        AddField("values");
        return this;
    }
}