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

public class MetaobjectFieldQueryBuilder() : GraphQueryBuilder<MetaobjectField>("query metaobjectField")
{
    public MetaobjectFieldQueryBuilder AddFieldDefinition()
    {
        AddField("definition");
        return this;
    }

    public MetaobjectFieldQueryBuilder AddFieldJsonValue()
    {
        AddField("jsonValue");
        return this;
    }

    public MetaobjectFieldQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public MetaobjectFieldQueryBuilder AddFieldReference()
    {
        AddField("reference");
        return this;
    }

    public MetaobjectFieldQueryBuilder AddFieldReferences()
    {
        AddField("references");
        return this;
    }

    public MetaobjectFieldQueryBuilder AddFieldThumbnail()
    {
        AddField("thumbnail");
        return this;
    }

    public MetaobjectFieldQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }

    public MetaobjectFieldQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}