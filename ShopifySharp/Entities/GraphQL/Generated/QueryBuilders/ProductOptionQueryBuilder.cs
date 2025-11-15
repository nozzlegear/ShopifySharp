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

public class ProductOptionQueryBuilder() : GraphQueryBuilder<ProductOption>("query productOption")
{
    public ProductOptionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ProductOptionQueryBuilder AddFieldLinkedMetafield()
    {
        AddField("linkedMetafield");
        return this;
    }

    public ProductOptionQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public ProductOptionQueryBuilder AddFieldOptionValues()
    {
        AddField("optionValues");
        return this;
    }

    public ProductOptionQueryBuilder AddFieldPosition()
    {
        AddField("position");
        return this;
    }

    public ProductOptionQueryBuilder AddFieldTranslations()
    {
        AddField("translations");
        return this;
    }

    public ProductOptionQueryBuilder AddFieldValues()
    {
        AddField("values");
        return this;
    }
}