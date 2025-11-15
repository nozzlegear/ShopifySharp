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

public class MetaobjectEdgeQueryBuilder() : GraphQueryBuilder<MetaobjectEdge>("query metaobjectEdge")
{
    public MetaobjectEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public MetaobjectEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}