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

public class MetaobjectDefinitionByTypeQueryBuilder() : GraphQueryBuilder<MetaobjectDefinition>("query metaobjectDefinitionByType")
{
    public MetaobjectDefinitionByTypeQueryBuilder AddArgumentType(string? type)
    {
        AddArgument("type", type);
        return this;
    }
}