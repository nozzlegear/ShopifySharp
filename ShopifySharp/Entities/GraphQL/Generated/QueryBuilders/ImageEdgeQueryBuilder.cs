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

public class ImageEdgeQueryBuilder() : GraphQueryBuilder<ImageEdge>("query imageEdge")
{
    public ImageEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ImageEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}