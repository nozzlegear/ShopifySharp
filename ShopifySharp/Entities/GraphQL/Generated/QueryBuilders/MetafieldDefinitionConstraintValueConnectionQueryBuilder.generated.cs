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

public class MetafieldDefinitionConstraintValueConnectionQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionConstraintValueConnection>("metafieldDefinitionConstraintValueConnection")
{
    public MetafieldDefinitionConstraintValueConnectionQueryBuilder AddFieldEdges(Func<MetafieldDefinitionConstraintValueEdgeQueryBuilder, MetafieldDefinitionConstraintValueEdgeQueryBuilder> build)
    {
        AddField<MetafieldDefinitionConstraintValueEdge, MetafieldDefinitionConstraintValueEdgeQueryBuilder>("edges", build);
        return this;
    }

    public MetafieldDefinitionConstraintValueConnectionQueryBuilder AddFieldNodes(Func<MetafieldDefinitionConstraintValueQueryBuilder, MetafieldDefinitionConstraintValueQueryBuilder> build)
    {
        AddField<MetafieldDefinitionConstraintValue, MetafieldDefinitionConstraintValueQueryBuilder>("nodes", build);
        return this;
    }

    public MetafieldDefinitionConstraintValueConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}