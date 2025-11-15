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

public class LocationEdgeQueryBuilder() : GraphQueryBuilder<LocationEdge>("query locationEdge")
{
    public LocationEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public LocationEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}