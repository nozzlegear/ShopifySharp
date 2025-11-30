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

public class ChannelDefinitionQueryBuilder() : GraphQueryBuilder<ChannelDefinition>("channelDefinition")
{
    public ChannelDefinitionQueryBuilder AddFieldChannelName()
    {
        AddField("channelName");
        return this;
    }

    public ChannelDefinitionQueryBuilder AddFieldHandle()
    {
        AddField("handle");
        return this;
    }

    public ChannelDefinitionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ChannelDefinitionQueryBuilder AddFieldIsMarketplace()
    {
        AddField("isMarketplace");
        return this;
    }

    public ChannelDefinitionQueryBuilder AddFieldSubChannelName()
    {
        AddField("subChannelName");
        return this;
    }

    [Obsolete("Use App.icon instead")]
    public ChannelDefinitionQueryBuilder AddFieldSvgIcon()
    {
        AddField("svgIcon");
        return this;
    }
}