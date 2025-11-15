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

public class MetafieldDefinitionQueryBuilder() : GraphQueryBuilder<MetafieldDefinition>("query metafieldDefinition")
{
    public MetafieldDefinitionQueryBuilder AddArgumentIdentifier(MetafieldDefinitionIdentifierInput? identifier)
    {
        AddArgument("identifier", identifier);
        return this;
    }
}