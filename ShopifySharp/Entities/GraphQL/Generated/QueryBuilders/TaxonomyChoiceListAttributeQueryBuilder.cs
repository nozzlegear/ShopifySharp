#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class TaxonomyChoiceListAttributeQueryBuilder() : GraphQueryBuilder<TaxonomyChoiceListAttribute>("query taxonomyChoiceListAttribute")
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

    public TaxonomyChoiceListAttributeQueryBuilder AddFieldValues()
    {
        AddField("values");
        return this;
    }
}