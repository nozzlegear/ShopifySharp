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

public class MetaobjectDefinitionEdgeQueryBuilder() : GraphQueryBuilder<MetaobjectDefinitionEdge>("metaobjectDefinitionEdge")
{
    public MetaobjectDefinitionEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public MetaobjectDefinitionEdgeQueryBuilder AddFieldNode(Func<MetaobjectDefinitionQueryBuilder, MetaobjectDefinitionQueryBuilder> build)
    {
        AddField<MetaobjectDefinition, MetaobjectDefinitionQueryBuilder>("node", build);
        return this;
    }
}