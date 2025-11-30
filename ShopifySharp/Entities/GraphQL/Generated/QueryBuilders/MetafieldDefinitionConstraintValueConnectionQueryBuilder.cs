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

public class MetafieldDefinitionConstraintValueConnectionQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionConstraintValueConnection>("query metafieldDefinitionConstraintValueConnection")
{
    public MetafieldDefinitionConstraintValueConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public MetafieldDefinitionConstraintValueConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public MetafieldDefinitionConstraintValueConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}