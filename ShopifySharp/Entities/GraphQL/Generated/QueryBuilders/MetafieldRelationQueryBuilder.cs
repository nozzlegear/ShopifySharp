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

public class MetafieldRelationQueryBuilder() : GraphQueryBuilder<MetafieldRelation>("query metafieldRelation")
{
    public MetafieldRelationQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public MetafieldRelationQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public MetafieldRelationQueryBuilder AddFieldNamespace()
    {
        AddField("namespace");
        return this;
    }

    public MetafieldRelationQueryBuilder AddFieldReferencer()
    {
        AddField("referencer");
        return this;
    }

    [Obsolete("No longer supported. Access the object directly instead.")]
    public MetafieldRelationQueryBuilder AddFieldTarget()
    {
        AddField("target");
        return this;
    }
}