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

public class MetafieldDefinitionCreatePayloadQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionCreatePayload>("query metafieldDefinitionCreatePayload")
{
    public MetafieldDefinitionCreatePayloadQueryBuilder AddFieldCreatedDefinition()
    {
        AddField("createdDefinition");
        return this;
    }

    public MetafieldDefinitionCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}