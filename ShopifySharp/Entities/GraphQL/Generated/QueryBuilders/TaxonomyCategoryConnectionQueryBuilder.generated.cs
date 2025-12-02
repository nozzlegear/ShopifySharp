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

public class TaxonomyCategoryConnectionQueryBuilder() : GraphQueryBuilder<TaxonomyCategoryConnection>("taxonomyCategoryConnection")
{
    public TaxonomyCategoryConnectionQueryBuilder AddFieldEdges(Func<TaxonomyCategoryEdgeQueryBuilder, TaxonomyCategoryEdgeQueryBuilder> build)
    {
        AddField<TaxonomyCategoryEdge, TaxonomyCategoryEdgeQueryBuilder>("edges", build);
        return this;
    }

    public TaxonomyCategoryConnectionQueryBuilder AddFieldNodes(Func<TaxonomyCategoryQueryBuilder, TaxonomyCategoryQueryBuilder> build)
    {
        AddField<TaxonomyCategory, TaxonomyCategoryQueryBuilder>("nodes", build);
        return this;
    }

    public TaxonomyCategoryConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}