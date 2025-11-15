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

public class AvailableChannelDefinitionsByChannelQueryBuilder() : GraphQueryBuilder<AvailableChannelDefinitionsByChannel>("query availableChannelDefinitionsByChannel")
{
    public AvailableChannelDefinitionsByChannelQueryBuilder AddFieldChannelDefinitions()
    {
        AddField("channelDefinitions");
        return this;
    }

    public AvailableChannelDefinitionsByChannelQueryBuilder AddFieldChannelName()
    {
        AddField("channelName");
        return this;
    }
}