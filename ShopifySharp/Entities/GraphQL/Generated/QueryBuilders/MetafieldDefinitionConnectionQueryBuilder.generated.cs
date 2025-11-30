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

public class MetafieldDefinitionConnectionQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionConnection>("metafieldDefinitionConnection")
{
    public MetafieldDefinitionConnectionQueryBuilder AddFieldEdges(Func<MetafieldDefinitionEdgeQueryBuilder, MetafieldDefinitionEdgeQueryBuilder> build)
    {
        AddField<MetafieldDefinitionEdge, MetafieldDefinitionEdgeQueryBuilder>("edges", build);
        return this;
    }

    public MetafieldDefinitionConnectionQueryBuilder AddFieldNodes(Func<MetafieldDefinitionQueryBuilder, MetafieldDefinitionQueryBuilder> build)
    {
        AddField<MetafieldDefinition, MetafieldDefinitionQueryBuilder>("nodes", build);
        return this;
    }

    public MetafieldDefinitionConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}