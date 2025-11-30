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

public class TaxonomyCategoryAttributeConnectionQueryBuilder() : GraphQueryBuilder<TaxonomyCategoryAttributeConnection>("taxonomyCategoryAttributeConnection")
{
    public TaxonomyCategoryAttributeConnectionQueryBuilder AddFieldEdges(Func<TaxonomyCategoryAttributeEdgeQueryBuilder, TaxonomyCategoryAttributeEdgeQueryBuilder> build)
    {
        AddField<TaxonomyCategoryAttributeEdge, TaxonomyCategoryAttributeEdgeQueryBuilder>("edges", build);
        return this;
    }

    public TaxonomyCategoryAttributeConnectionQueryBuilder AddUnionCaseNodes(Func<TaxonomyAttributeQueryBuilder, TaxonomyAttributeQueryBuilder> build)
    {
        AddUnion<TaxonomyAttribute, TaxonomyAttributeQueryBuilder>("nodes", build);
        return this;
    }

    public TaxonomyCategoryAttributeConnectionQueryBuilder AddUnionCaseNodes(Func<TaxonomyChoiceListAttributeQueryBuilder, TaxonomyChoiceListAttributeQueryBuilder> build)
    {
        AddUnion<TaxonomyChoiceListAttribute, TaxonomyChoiceListAttributeQueryBuilder>("nodes", build);
        return this;
    }

    public TaxonomyCategoryAttributeConnectionQueryBuilder AddUnionCaseNodes(Func<TaxonomyMeasurementAttributeQueryBuilder, TaxonomyMeasurementAttributeQueryBuilder> build)
    {
        AddUnion<TaxonomyMeasurementAttribute, TaxonomyMeasurementAttributeQueryBuilder>("nodes", build);
        return this;
    }

    public TaxonomyCategoryAttributeConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}