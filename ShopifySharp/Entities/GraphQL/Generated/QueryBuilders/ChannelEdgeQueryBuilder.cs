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

public class ChannelEdgeQueryBuilder() : GraphQueryBuilder<ChannelEdge>("query channelEdge")
{
    public ChannelEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ChannelEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}