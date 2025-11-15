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

public class MetafieldDefinitionPinQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionPinPayload>("query metafieldDefinitionPin")
{
    public MetafieldDefinitionPinQueryBuilder AddArgumentDefinitionId(string? definitionId)
    {
        AddArgument("definitionId", definitionId);
        return this;
    }

    public MetafieldDefinitionPinQueryBuilder AddArgumentIdentifier(MetafieldDefinitionIdentifierInput? identifier)
    {
        AddArgument("identifier", identifier);
        return this;
    }
}