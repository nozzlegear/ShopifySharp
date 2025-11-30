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

public class MarketWebPresenceEdgeQueryBuilder() : GraphQueryBuilder<MarketWebPresenceEdge>("query marketWebPresenceEdge")
{
    public MarketWebPresenceEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public MarketWebPresenceEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}