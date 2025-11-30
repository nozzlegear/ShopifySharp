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

public class MetaobjectEdgeQueryBuilder() : GraphQueryBuilder<MetaobjectEdge>("metaobjectEdge")
{
    public MetaobjectEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public MetaobjectEdgeQueryBuilder AddFieldNode(Func<MetaobjectQueryBuilder, MetaobjectQueryBuilder> build)
    {
        AddField<Metaobject, MetaobjectQueryBuilder>("node", build);
        return this;
    }
}