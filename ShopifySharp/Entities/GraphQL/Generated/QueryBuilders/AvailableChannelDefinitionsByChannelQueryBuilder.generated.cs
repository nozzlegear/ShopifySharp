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

public class AvailableChannelDefinitionsByChannelQueryBuilder() : GraphQueryBuilder<AvailableChannelDefinitionsByChannel>("availableChannelDefinitionsByChannel")
{
    public AvailableChannelDefinitionsByChannelQueryBuilder AddFieldChannelDefinitions(Func<ChannelDefinitionQueryBuilder, ChannelDefinitionQueryBuilder> build)
    {
        AddField<ChannelDefinition, ChannelDefinitionQueryBuilder>("channelDefinitions", build);
        return this;
    }

    public AvailableChannelDefinitionsByChannelQueryBuilder AddFieldChannelName()
    {
        AddField("channelName");
        return this;
    }
}