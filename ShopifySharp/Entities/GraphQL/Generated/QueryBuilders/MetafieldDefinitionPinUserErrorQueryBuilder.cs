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

public class MetafieldDefinitionPinUserErrorQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionPinUserError>("query metafieldDefinitionPinUserError")
{
    public MetafieldDefinitionPinUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public MetafieldDefinitionPinUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public MetafieldDefinitionPinUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}