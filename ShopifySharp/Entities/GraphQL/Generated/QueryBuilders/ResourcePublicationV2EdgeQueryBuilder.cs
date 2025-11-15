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

public class ResourcePublicationV2EdgeQueryBuilder() : GraphQueryBuilder<ResourcePublicationV2Edge>("query resourcePublicationV2Edge")
{
    public ResourcePublicationV2EdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ResourcePublicationV2EdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}