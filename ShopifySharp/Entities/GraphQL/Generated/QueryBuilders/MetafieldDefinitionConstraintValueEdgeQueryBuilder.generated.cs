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

public class MetafieldDefinitionConstraintValueEdgeQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionConstraintValueEdge>("metafieldDefinitionConstraintValueEdge")
{
    public MetafieldDefinitionConstraintValueEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public MetafieldDefinitionConstraintValueEdgeQueryBuilder AddFieldNode(Func<MetafieldDefinitionConstraintValueQueryBuilder, MetafieldDefinitionConstraintValueQueryBuilder> build)
    {
        AddField<MetafieldDefinitionConstraintValue, MetafieldDefinitionConstraintValueQueryBuilder>("node", build);
        return this;
    }
}