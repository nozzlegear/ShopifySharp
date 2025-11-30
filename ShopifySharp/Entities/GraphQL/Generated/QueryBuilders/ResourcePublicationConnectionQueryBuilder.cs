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

public class ResourcePublicationConnectionQueryBuilder() : GraphQueryBuilder<ResourcePublicationConnection>("query resourcePublicationConnection")
{
    public ResourcePublicationConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public ResourcePublicationConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public ResourcePublicationConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}