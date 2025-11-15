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

public class MetaobjectDefinitionConnectionQueryBuilder() : GraphQueryBuilder<MetaobjectDefinitionConnection>("query metaobjectDefinitionConnection")
{
    public MetaobjectDefinitionConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public MetaobjectDefinitionConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public MetaobjectDefinitionConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}