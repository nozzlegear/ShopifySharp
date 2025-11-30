#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ChannelEdgeQueryBuilder() : GraphQueryBuilder<ChannelEdge>("channelEdge")
{
    public ChannelEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ChannelEdgeQueryBuilder AddFieldNode(Func<ChannelQueryBuilder, ChannelQueryBuilder> build)
    {
        AddField<Channel, ChannelQueryBuilder>("node", build);
        return this;
    }
}