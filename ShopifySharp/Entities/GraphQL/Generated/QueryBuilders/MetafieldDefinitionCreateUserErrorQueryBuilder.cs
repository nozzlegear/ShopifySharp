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

public class MetafieldDefinitionCreateUserErrorQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionCreateUserError>("query metafieldDefinitionCreateUserError")
{
    public MetafieldDefinitionCreateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public MetafieldDefinitionCreateUserErrorQueryBuilder AddFieldElementIndex()
    {
        AddField("elementIndex");
        return this;
    }

    public MetafieldDefinitionCreateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public MetafieldDefinitionCreateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}