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

public class TaxonomyCategoryAttributeEdgeQueryBuilder() : GraphQueryBuilder<TaxonomyCategoryAttributeEdge>("taxonomyCategoryAttributeEdge")
{
    public TaxonomyCategoryAttributeEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public TaxonomyCategoryAttributeEdgeQueryBuilder AddUnionCaseNode(Func<TaxonomyAttributeQueryBuilder, TaxonomyAttributeQueryBuilder> build)
    {
        AddUnion<TaxonomyAttribute, TaxonomyAttributeQueryBuilder>("node", build);
        return this;
    }

    public TaxonomyCategoryAttributeEdgeQueryBuilder AddUnionCaseNode(Func<TaxonomyChoiceListAttributeQueryBuilder, TaxonomyChoiceListAttributeQueryBuilder> build)
    {
        AddUnion<TaxonomyChoiceListAttribute, TaxonomyChoiceListAttributeQueryBuilder>("node", build);
        return this;
    }

    public TaxonomyCategoryAttributeEdgeQueryBuilder AddUnionCaseNode(Func<TaxonomyMeasurementAttributeQueryBuilder, TaxonomyMeasurementAttributeQueryBuilder> build)
    {
        AddUnion<TaxonomyMeasurementAttribute, TaxonomyMeasurementAttributeQueryBuilder>("node", build);
        return this;
    }
}