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

public class ShopLocaleQueryBuilder() : GraphQueryBuilder<ShopLocale>("query shopLocale")
{
    public ShopLocaleQueryBuilder AddFieldLocale()
    {
        AddField("locale");
        return this;
    }

    public ShopLocaleQueryBuilder AddFieldMarketWebPresences()
    {
        AddField("marketWebPresences");
        return this;
    }

    public ShopLocaleQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public ShopLocaleQueryBuilder AddFieldPrimary()
    {
        AddField("primary");
        return this;
    }

    public ShopLocaleQueryBuilder AddFieldPublished()
    {
        AddField("published");
        return this;
    }
}