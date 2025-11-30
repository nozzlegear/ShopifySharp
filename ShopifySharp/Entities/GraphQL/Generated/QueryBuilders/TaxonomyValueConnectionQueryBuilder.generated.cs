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

public class TaxonomyValueConnectionQueryBuilder() : GraphQueryBuilder<TaxonomyValueConnection>("taxonomyValueConnection")
{
    public TaxonomyValueConnectionQueryBuilder AddFieldEdges(Func<TaxonomyValueEdgeQueryBuilder, TaxonomyValueEdgeQueryBuilder> build)
    {
        AddField<TaxonomyValueEdge, TaxonomyValueEdgeQueryBuilder>("edges", build);
        return this;
    }

    public TaxonomyValueConnectionQueryBuilder AddFieldNodes(Func<TaxonomyValueQueryBuilder, TaxonomyValueQueryBuilder> build)
    {
        AddField<TaxonomyValue, TaxonomyValueQueryBuilder>("nodes", build);
        return this;
    }

    public TaxonomyValueConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}