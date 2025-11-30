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

public class MetafieldQueryBuilder() : GraphQueryBuilder<Metafield>("query metafield")
{
    public MetafieldQueryBuilder AddFieldCompareDigest()
    {
        AddField("compareDigest");
        return this;
    }

    public MetafieldQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public MetafieldQueryBuilder AddFieldDefinition()
    {
        AddField("definition");
        return this;
    }

    [Obsolete("This field will be removed in a future release. Use the `description` on the metafield definition instead. ")]
    public MetafieldQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public MetafieldQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public MetafieldQueryBuilder AddFieldJsonValue()
    {
        AddField("jsonValue");
        return this;
    }

    public MetafieldQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public MetafieldQueryBuilder AddFieldLegacyResourceId()
    {
        AddField("legacyResourceId");
        return this;
    }

    public MetafieldQueryBuilder AddFieldNamespace()
    {
        AddField("namespace");
        return this;
    }

    public MetafieldQueryBuilder AddFieldOwner()
    {
        AddField("owner");
        return this;
    }

    public MetafieldQueryBuilder AddFieldOwnerType()
    {
        AddField("ownerType");
        return this;
    }

    public MetafieldQueryBuilder AddFieldReference()
    {
        AddField("reference");
        return this;
    }

    public MetafieldQueryBuilder AddFieldReferences()
    {
        AddField("references");
        return this;
    }

    public MetafieldQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }

    public MetafieldQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }

    public MetafieldQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}