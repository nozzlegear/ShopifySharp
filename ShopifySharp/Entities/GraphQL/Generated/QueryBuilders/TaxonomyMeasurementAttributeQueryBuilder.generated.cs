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

public class TaxonomyMeasurementAttributeQueryBuilder() : GraphQueryBuilder<TaxonomyMeasurementAttribute>("taxonomyMeasurementAttribute")
{
    public TaxonomyMeasurementAttributeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public TaxonomyMeasurementAttributeQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public TaxonomyMeasurementAttributeQueryBuilder AddFieldOptions(Func<AttributeQueryBuilder, AttributeQueryBuilder> build)
    {
        AddField<ShopifySharp.GraphQL.Attribute, AttributeQueryBuilder>("options", build);
        return this;
    }
}