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

public class TranslatableContentQueryBuilder() : GraphQueryBuilder<TranslatableContent>("query translatableContent")
{
    public TranslatableContentQueryBuilder AddFieldDigest()
    {
        AddField("digest");
        return this;
    }

    public TranslatableContentQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public TranslatableContentQueryBuilder AddFieldLocale()
    {
        AddField("locale");
        return this;
    }

    public TranslatableContentQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }

    public TranslatableContentQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}