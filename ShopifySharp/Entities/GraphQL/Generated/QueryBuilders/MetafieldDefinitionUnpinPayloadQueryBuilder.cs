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

public class MetafieldDefinitionUnpinPayloadQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionUnpinPayload>("query metafieldDefinitionUnpinPayload")
{
    public MetafieldDefinitionUnpinPayloadQueryBuilder AddFieldUnpinnedDefinition()
    {
        AddField("unpinnedDefinition");
        return this;
    }

    public MetafieldDefinitionUnpinPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}