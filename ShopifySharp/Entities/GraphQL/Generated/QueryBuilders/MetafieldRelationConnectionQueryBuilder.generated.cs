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

public class MetafieldRelationConnectionQueryBuilder() : GraphQueryBuilder<MetafieldRelationConnection>("metafieldRelationConnection")
{
    public MetafieldRelationConnectionQueryBuilder AddFieldEdges(Func<MetafieldRelationEdgeQueryBuilder, MetafieldRelationEdgeQueryBuilder> build)
    {
        AddField<MetafieldRelationEdge, MetafieldRelationEdgeQueryBuilder>("edges", build);
        return this;
    }

    public MetafieldRelationConnectionQueryBuilder AddFieldNodes(Func<MetafieldRelationQueryBuilder, MetafieldRelationQueryBuilder> build)
    {
        AddField<MetafieldRelation, MetafieldRelationQueryBuilder>("nodes", build);
        return this;
    }

    public MetafieldRelationConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}