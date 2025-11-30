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

public class TypedAttributeQueryBuilder() : GraphQueryBuilder<TypedAttribute>("query typedAttribute")
{
    public TypedAttributeQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public TypedAttributeQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}