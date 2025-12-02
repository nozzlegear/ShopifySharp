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

public class ChannelInformationQueryBuilder() : GraphQueryBuilder<ChannelInformation>("channelInformation")
{
    public ChannelInformationQueryBuilder AddFieldApp(Func<AppQueryBuilder, AppQueryBuilder> build)
    {
        AddField<App, AppQueryBuilder>("app", build);
        return this;
    }

    public ChannelInformationQueryBuilder AddFieldChannelDefinition(Func<ChannelDefinitionQueryBuilder, ChannelDefinitionQueryBuilder> build)
    {
        AddField<ChannelDefinition, ChannelDefinitionQueryBuilder>("channelDefinition", build);
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