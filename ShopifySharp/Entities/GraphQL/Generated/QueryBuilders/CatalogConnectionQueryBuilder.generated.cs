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

public class CatalogConnectionQueryBuilder() : GraphQueryBuilder<CatalogConnection>("catalogConnection")
{
    public CatalogConnectionQueryBuilder AddFieldEdges(Func<CatalogEdgeQueryBuilder, CatalogEdgeQueryBuilder> build)
    {
        AddField<CatalogEdge, CatalogEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CatalogConnectionQueryBuilder AddFieldNodes(Func<CatalogQueryBuilder, CatalogQueryBuilder> build)
    {
        AddField<ICatalog, CatalogQueryBuilder>("nodes", build);
        return this;
    }

    public CatalogConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}