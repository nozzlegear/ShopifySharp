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

public class MetafieldDefinitionUpdateQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionUpdatePayload>("query metafieldDefinitionUpdate")
{
    public MetafieldDefinitionUpdateQueryBuilder AddArgumentDefinition(MetafieldDefinitionUpdateInput? definition)
    {
        AddArgument("definition", definition);
        return this;
    }
}