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

public class MetafieldRelationEdgeQueryBuilder() : GraphQueryBuilder<MetafieldRelationEdge>("metafieldRelationEdge")
{
    public MetafieldRelationEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public MetafieldRelationEdgeQueryBuilder AddFieldNode(Func<MetafieldRelationQueryBuilder, MetafieldRelationQueryBuilder> build)
    {
        AddField<MetafieldRelation, MetafieldRelationQueryBuilder>("node", build);
        return this;
    }
}