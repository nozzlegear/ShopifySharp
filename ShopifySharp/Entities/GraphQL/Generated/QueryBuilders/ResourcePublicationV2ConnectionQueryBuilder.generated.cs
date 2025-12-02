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

public class ResourcePublicationV2ConnectionQueryBuilder() : GraphQueryBuilder<ResourcePublicationV2Connection>("resourcePublicationV2Connection")
{
    public ResourcePublicationV2ConnectionQueryBuilder AddFieldEdges(Func<ResourcePublicationV2EdgeQueryBuilder, ResourcePublicationV2EdgeQueryBuilder> build)
    {
        AddField<ResourcePublicationV2Edge, ResourcePublicationV2EdgeQueryBuilder>("edges", build);
        return this;
    }

    public ResourcePublicationV2ConnectionQueryBuilder AddFieldNodes(Func<ResourcePublicationV2QueryBuilder, ResourcePublicationV2QueryBuilder> build)
    {
        AddField<ResourcePublicationV2, ResourcePublicationV2QueryBuilder>("nodes", build);
        return this;
    }

    public ResourcePublicationV2ConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}