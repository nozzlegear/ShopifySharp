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

public class ChannelConnectionQueryBuilder() : GraphQueryBuilder<ChannelConnection>("channelConnection")
{
    public ChannelConnectionQueryBuilder AddFieldEdges(Func<ChannelEdgeQueryBuilder, ChannelEdgeQueryBuilder> build)
    {
        AddField<ChannelEdge, ChannelEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ChannelConnectionQueryBuilder AddFieldNodes(Func<ChannelQueryBuilder, ChannelQueryBuilder> build)
    {
        AddField<Channel, ChannelQueryBuilder>("nodes", build);
        return this;
    }

    public ChannelConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}