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

public class MetaobjectConnectionQueryBuilder() : GraphQueryBuilder<MetaobjectConnection>("metaobjectConnection")
{
    public MetaobjectConnectionQueryBuilder AddFieldEdges(Func<MetaobjectEdgeQueryBuilder, MetaobjectEdgeQueryBuilder> build)
    {
        AddField<MetaobjectEdge, MetaobjectEdgeQueryBuilder>("edges", build);
        return this;
    }

    public MetaobjectConnectionQueryBuilder AddFieldNodes(Func<MetaobjectQueryBuilder, MetaobjectQueryBuilder> build)
    {
        AddField<Metaobject, MetaobjectQueryBuilder>("nodes", build);
        return this;
    }

    public MetaobjectConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}