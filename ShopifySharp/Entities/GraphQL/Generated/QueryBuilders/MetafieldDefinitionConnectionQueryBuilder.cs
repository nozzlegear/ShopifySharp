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

public class MetafieldDefinitionConnectionQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionConnection>("query metafieldDefinitionConnection")
{
    public MetafieldDefinitionConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public MetafieldDefinitionConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public MetafieldDefinitionConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}