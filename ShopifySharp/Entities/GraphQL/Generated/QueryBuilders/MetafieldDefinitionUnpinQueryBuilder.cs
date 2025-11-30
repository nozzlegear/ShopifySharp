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

public class MetafieldDefinitionUnpinQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionUnpinPayload>("query metafieldDefinitionUnpin")
{
    public MetafieldDefinitionUnpinQueryBuilder AddArgumentDefinitionId(string? definitionId)
    {
        AddArgument("definitionId", definitionId);
        return this;
    }

    public MetafieldDefinitionUnpinQueryBuilder AddArgumentIdentifier(MetafieldDefinitionIdentifierInput? identifier)
    {
        AddArgument("identifier", identifier);
        return this;
    }
}