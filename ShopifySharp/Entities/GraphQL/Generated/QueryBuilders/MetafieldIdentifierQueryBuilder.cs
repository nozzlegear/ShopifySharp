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

public class MetafieldIdentifierQueryBuilder() : GraphQueryBuilder<MetafieldIdentifier>("query metafieldIdentifier")
{
    public MetafieldIdentifierQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public MetafieldIdentifierQueryBuilder AddFieldNamespace()
    {
        AddField("namespace");
        return this;
    }

    public MetafieldIdentifierQueryBuilder AddFieldOwnerId()
    {
        AddField("ownerId");
        return this;
    }
}