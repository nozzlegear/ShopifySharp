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

public class MetaobjectDefinitionConnectionQueryBuilder() : GraphQueryBuilder<MetaobjectDefinitionConnection>("metaobjectDefinitionConnection")
{
    public MetaobjectDefinitionConnectionQueryBuilder AddFieldEdges(Func<MetaobjectDefinitionEdgeQueryBuilder, MetaobjectDefinitionEdgeQueryBuilder> build)
    {
        AddField<MetaobjectDefinitionEdge, MetaobjectDefinitionEdgeQueryBuilder>("edges", build);
        return this;
    }

    public MetaobjectDefinitionConnectionQueryBuilder AddFieldNodes(Func<MetaobjectDefinitionQueryBuilder, MetaobjectDefinitionQueryBuilder> build)
    {
        AddField<MetaobjectDefinition, MetaobjectDefinitionQueryBuilder>("nodes", build);
        return this;
    }

    public MetaobjectDefinitionConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}