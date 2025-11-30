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

public class LocalizedFieldConnectionQueryBuilder() : GraphQueryBuilder<LocalizedFieldConnection>("localizedFieldConnection")
{
    public LocalizedFieldConnectionQueryBuilder AddFieldEdges(Func<LocalizedFieldEdgeQueryBuilder, LocalizedFieldEdgeQueryBuilder> build)
    {
        AddField<LocalizedFieldEdge, LocalizedFieldEdgeQueryBuilder>("edges", build);
        return this;
    }

    public LocalizedFieldConnectionQueryBuilder AddFieldNodes(Func<LocalizedFieldQueryBuilder, LocalizedFieldQueryBuilder> build)
    {
        AddField<LocalizedField, LocalizedFieldQueryBuilder>("nodes", build);
        return this;
    }

    public LocalizedFieldConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}