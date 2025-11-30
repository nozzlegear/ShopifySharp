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

public class MetafieldConnectionQueryBuilder() : GraphQueryBuilder<MetafieldConnection>("metafieldConnection")
{
    public MetafieldConnectionQueryBuilder AddFieldEdges(Func<MetafieldEdgeQueryBuilder, MetafieldEdgeQueryBuilder> build)
    {
        AddField<MetafieldEdge, MetafieldEdgeQueryBuilder>("edges", build);
        return this;
    }

    public MetafieldConnectionQueryBuilder AddFieldNodes(Func<MetafieldQueryBuilder, MetafieldQueryBuilder> build)
    {
        AddField<Metafield, MetafieldQueryBuilder>("nodes", build);
        return this;
    }

    public MetafieldConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}