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

public class ResourcePublicationV2ConnectionQueryBuilder() : GraphQueryBuilder<ResourcePublicationV2Connection>("query resourcePublicationV2Connection")
{
    public ResourcePublicationV2ConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public ResourcePublicationV2ConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public ResourcePublicationV2ConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}