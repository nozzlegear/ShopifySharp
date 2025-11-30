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

public class ResourcePublicationEdgeQueryBuilder() : GraphQueryBuilder<ResourcePublicationEdge>("resourcePublicationEdge")
{
    public ResourcePublicationEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ResourcePublicationEdgeQueryBuilder AddFieldNode(Func<ResourcePublicationQueryBuilder, ResourcePublicationQueryBuilder> build)
    {
        AddField<ResourcePublication, ResourcePublicationQueryBuilder>("node", build);
        return this;
    }
}