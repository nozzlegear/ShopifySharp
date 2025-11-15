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

public class StandardMetafieldDefinitionTemplateConnectionQueryBuilder() : GraphQueryBuilder<StandardMetafieldDefinitionTemplateConnection>("query standardMetafieldDefinitionTemplateConnection")
{
    public StandardMetafieldDefinitionTemplateConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public StandardMetafieldDefinitionTemplateConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public StandardMetafieldDefinitionTemplateConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}