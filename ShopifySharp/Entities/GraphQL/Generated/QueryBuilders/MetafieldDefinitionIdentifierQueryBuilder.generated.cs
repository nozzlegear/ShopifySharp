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

public class MetafieldDefinitionIdentifierQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionIdentifier>("metafieldDefinitionIdentifier")
{
    public MetafieldDefinitionIdentifierQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public MetafieldDefinitionIdentifierQueryBuilder AddFieldNamespace()
    {
        AddField("namespace");
        return this;
    }

    public MetafieldDefinitionIdentifierQueryBuilder AddFieldOwnerType()
    {
        AddField("ownerType");
        return this;
    }
}