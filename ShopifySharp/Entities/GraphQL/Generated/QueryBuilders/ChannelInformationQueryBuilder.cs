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

public class ChannelInformationQueryBuilder() : GraphQueryBuilder<ChannelInformation>("query channelInformation")
{
    public ChannelInformationQueryBuilder AddFieldApp()
    {
        AddField("app");
        return this;
    }

    public ChannelInformationQueryBuilder AddFieldChannelDefinition()
    {
        AddField("channelDefinition");
        return this;
    }

    public ChannelInformationQueryBuilder AddFieldChannelId()
    {
        AddField("channelId");
        return this;
    }

    public ChannelInformationQueryBuilder AddFieldDisplayName()
    {
        AddField("displayName");
        return this;
    }

    public ChannelInformationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }
}