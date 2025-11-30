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

public class ProductOptionValueQueryBuilder() : GraphQueryBuilder<ProductOptionValue>("productOptionValue")
{
    public ProductOptionValueQueryBuilder AddFieldHasVariants()
    {
        AddField("hasVariants");
        return this;
    }

    public ProductOptionValueQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ProductOptionValueQueryBuilder AddFieldLinkedMetafieldValue()
    {
        AddField("linkedMetafieldValue");
        return this;
    }

    public ProductOptionValueQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public ProductOptionValueQueryBuilder AddFieldSwatch(Func<ProductOptionValueSwatchQueryBuilder, ProductOptionValueSwatchQueryBuilder> build)
    {
        AddField<ProductOptionValueSwatch, ProductOptionValueSwatchQueryBuilder>("swatch", build);
        return this;
    }

    public ProductOptionValueQueryBuilder AddFieldTranslations(Func<TranslationQueryBuilder, TranslationQueryBuilder> build)
    {
        AddField<Translation, TranslationQueryBuilder>("translations", build);
        return this;
    }
}