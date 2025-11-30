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

public class ResourcePublicationV2EdgeQueryBuilder() : GraphQueryBuilder<ResourcePublicationV2Edge>("resourcePublicationV2Edge")
{
    public ResourcePublicationV2EdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ResourcePublicationV2EdgeQueryBuilder AddFieldNode(Func<ResourcePublicationV2QueryBuilder, ResourcePublicationV2QueryBuilder> build)
    {
        AddField<ResourcePublicationV2, ResourcePublicationV2QueryBuilder>("node", build);
        return this;
    }
}