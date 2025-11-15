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

public class MetafieldReferenceEdgeQueryBuilder() : GraphQueryBuilder<MetafieldReferenceEdge>("query metafieldReferenceEdge")
{
    public MetafieldReferenceEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public MetafieldReferenceEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}