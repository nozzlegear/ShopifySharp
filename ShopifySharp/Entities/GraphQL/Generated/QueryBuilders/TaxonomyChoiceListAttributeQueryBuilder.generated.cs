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

public class TaxonomyChoiceListAttributeQueryBuilder() : GraphQueryBuilder<TaxonomyChoiceListAttribute>("taxonomyChoiceListAttribute")
{
    public TaxonomyChoiceListAttributeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public TaxonomyChoiceListAttributeQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public TaxonomyChoiceListAttributeQueryBuilder AddFieldValues(Func<TaxonomyValueConnectionQueryBuilder, TaxonomyValueConnectionQueryBuilder> build)
    {
        AddField<TaxonomyValueConnection, TaxonomyValueConnectionQueryBuilder>("values", build);
        return this;
    }
}