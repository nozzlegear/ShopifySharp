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

public class MetafieldDefinitionEdgeQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionEdge>("metafieldDefinitionEdge")
{
    public MetafieldDefinitionEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public MetafieldDefinitionEdgeQueryBuilder AddFieldNode(Func<MetafieldDefinitionQueryBuilder, MetafieldDefinitionQueryBuilder> build)
    {
        AddField<MetafieldDefinition, MetafieldDefinitionQueryBuilder>("node", build);
        return this;
    }
}