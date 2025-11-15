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

public class MetafieldDefinitionDeletePayloadQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionDeletePayload>("query metafieldDefinitionDeletePayload")
{
    public MetafieldDefinitionDeletePayloadQueryBuilder AddFieldDeletedDefinition()
    {
        AddField("deletedDefinition");
        return this;
    }

    public MetafieldDefinitionDeletePayloadQueryBuilder AddFieldDeletedDefinitionId()
    {
        AddField("deletedDefinitionId");
        return this;
    }

    public MetafieldDefinitionDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}