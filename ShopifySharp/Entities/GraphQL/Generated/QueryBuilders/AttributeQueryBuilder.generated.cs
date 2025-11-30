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

public class AttributeQueryBuilder() : GraphQueryBuilder<ShopifySharp.GraphQL.Attribute>("attribute")
{
    public AttributeQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public AttributeQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}