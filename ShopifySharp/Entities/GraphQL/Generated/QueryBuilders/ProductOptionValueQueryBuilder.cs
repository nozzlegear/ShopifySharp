#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ProductOptionValueQueryBuilder() : GraphQueryBuilder<ProductOptionValue>("query productOptionValue")
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

    public ProductOptionValueQueryBuilder AddFieldSwatch()
    {
        AddField("swatch");
        return this;
    }

    public ProductOptionValueQueryBuilder AddFieldTranslations()
    {
        AddField("translations");
        return this;
    }
}