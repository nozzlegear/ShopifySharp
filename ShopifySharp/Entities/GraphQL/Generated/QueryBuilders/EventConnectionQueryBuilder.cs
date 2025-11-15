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

public class EventConnectionQueryBuilder() : GraphQueryBuilder<EventConnection>("query eventConnection")
{
    public EventConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public EventConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public EventConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}