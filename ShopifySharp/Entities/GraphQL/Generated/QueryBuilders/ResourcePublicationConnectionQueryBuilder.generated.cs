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

public class ResourcePublicationConnectionQueryBuilder() : GraphQueryBuilder<ResourcePublicationConnection>("resourcePublicationConnection")
{
    public ResourcePublicationConnectionQueryBuilder AddFieldEdges(Func<ResourcePublicationEdgeQueryBuilder, ResourcePublicationEdgeQueryBuilder> build)
    {
        AddField<ResourcePublicationEdge, ResourcePublicationEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ResourcePublicationConnectionQueryBuilder AddFieldNodes(Func<ResourcePublicationQueryBuilder, ResourcePublicationQueryBuilder> build)
    {
        AddField<ResourcePublication, ResourcePublicationQueryBuilder>("nodes", build);
        return this;
    }

    public ResourcePublicationConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}