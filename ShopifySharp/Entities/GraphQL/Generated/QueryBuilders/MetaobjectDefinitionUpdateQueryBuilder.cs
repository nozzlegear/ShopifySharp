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

public class MetaobjectDefinitionUpdateQueryBuilder() : GraphQueryBuilder<MetaobjectDefinitionUpdatePayload>("query metaobjectDefinitionUpdate")
{
    public MetaobjectDefinitionUpdateQueryBuilder AddArgumentDefinition(MetaobjectDefinitionUpdateInput? definition)
    {
        AddArgument("definition", definition);
        return this;
    }

    public MetaobjectDefinitionUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}