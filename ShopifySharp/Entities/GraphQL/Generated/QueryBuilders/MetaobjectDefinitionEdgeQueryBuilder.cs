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

public class MetaobjectDefinitionEdgeQueryBuilder() : GraphQueryBuilder<MetaobjectDefinitionEdge>("query metaobjectDefinitionEdge")
{
    public MetaobjectDefinitionEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public MetaobjectDefinitionEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}