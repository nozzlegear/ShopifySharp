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

public class MetafieldDefinitionConstraintsQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionConstraints>("query metafieldDefinitionConstraints")
{
    public MetafieldDefinitionConstraintsQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public MetafieldDefinitionConstraintsQueryBuilder AddFieldValues()
    {
        AddField("values");
        return this;
    }
}